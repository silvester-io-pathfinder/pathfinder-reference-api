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
    public class WritingSet : Template
    {
        public static readonly Guid ID = Guid.Parse("a4a36408-ce6b-4f60-b6eb-fe4dfb274319");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Wiriting Set",
                Hands = "2",
                ItemLevel = "0",
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3caa046c-fb10-414e-993a-b6f2516f2133"), Type = TextBlockType.Text, Text = "Using a writing set, you can draft correspondence and scribe scrolls. A set includes stationery, including a variety of paper and parchment, as well as ink, a quill or inkpen, sealing wax, and a simple seal." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("40f98c83-06bd-46eb-bf55-db5a5917d157"),
                NameAddendum = "Extra Ink and Paper",
                DescriptionAddendum = "If you’ve written a large amount, you can refill your kit with extra ink and paper.",
                ItemLevel = 0,
                Price = 10,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b09ae9e9-3fb0-463e-bd24-28529ebfe3fc"),
                SourceId = CoreRulebook.ID,
                Page = 292
            };
        }
    }
}
