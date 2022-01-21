using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class WritingSet : Template
    {
        public static readonly Guid ID = Guid.Parse("a4a36408-ce6b-4f60-b6eb-fe4dfb274319");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Writing Set",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3caa046c-fb10-414e-993a-b6f2516f2133"), "Using a writing set, you can draft correspondence and scribe scrolls. A set includes stationery, including a variety of paper and parchment, as well as ink, a quill or inkpen, sealing wax, and a simple seal.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {    
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4f6361b0-395f-483d-b1b5-0b139d1b9efd"),
                Name = "Writing Set",
                Hands = "2",
                Level = 0,
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
            
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("40f98c83-06bd-46eb-bf55-db5a5917d157"),
                Name = "Extra Ink and Paper",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("db7de790-441a-4ee7-a6e9-37b5a618a64d"), "If you've written a large amount, you can refill your kit with extra ink and paper.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b09ae9e9-3fb0-463e-bd24-28529ebfe3fc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 292
            };
        }
    }
}
