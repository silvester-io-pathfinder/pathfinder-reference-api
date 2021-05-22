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
    public class MagnifyingGlass : Template
    {
        public static readonly Guid ID = Guid.Parse("9417ac00-4b72-460a-a6dc-ad961c03ab14");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Magnifying Glass",
                Hands = "1",
                ItemLevel = "0",
                Price = 4000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("302c42ec-e59f-4f42-8e90-0073770e9f95"), Type = TextBlockType.Text, Text = "This quality handheld lens gives you a +1 item bonus to Perception checks to notice minute details of documents, fabric, and the like." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d8a755d-21da-415f-aadf-a0b8b4a4c185"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
