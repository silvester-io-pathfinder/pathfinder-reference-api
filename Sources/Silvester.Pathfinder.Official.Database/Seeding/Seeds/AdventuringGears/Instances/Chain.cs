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
    public class Chain : Template
    {
        public static readonly Guid ID = Guid.Parse("86a1f1d8-b158-4ec2-ab49-dc7795b59b48");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Chain",
                Hands = "2",
                ItemLevel = "0",
                Price = 400,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1359695a-751d-41a5-a4bc-31f1cd8baa62"), Type = TextBlockType.Text, Text = "A chain is a serial assembly of connected pieces, called links, typically made of metal, with an overall character similar to that of a rope in that it is flexible and curved in compression but linear, rigid, and load-bearing in tension. A chain may consist of two or more links." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21625357-762f-4ebe-99e2-b3756c24a1bb"),
                SourceId = CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
