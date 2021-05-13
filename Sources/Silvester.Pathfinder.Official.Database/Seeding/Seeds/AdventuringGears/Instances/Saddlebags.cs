using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Saddlebags : Template
    {
        public static readonly Guid ID = Guid.Parse("53af75a3-f02a-4a31-8a6c-63c292192228");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Saddlebags",
                Hands = "2",
                ItemLevel = "0",
                Price = 20,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4e1e1d35-9b89-462d-a981-baa50eddd958"), Type = TextBlockType.Text, Text = "Saddlebags come in a pair. Each can hold up to 3 Bulk of items, and the first 1 Bulk of items in each doesn't count against your mount's Bulk limit. The Bulk value given is for saddlebags worn by a mount. If you are carrying or stowing saddlebags, they count as 1 Bulk instead of light Bulk." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8a0a3c7-2a02-49cf-bb00-7600e9c7a1ae"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
