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
    public class FishingTackle : Template
    {
        public static readonly Guid ID = Guid.Parse("48f8e6d1-38dd-4ae7-966b-d85778977991");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Fishing Tackle",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f46a0e3c-1746-40bc-8f13-fd6c86e3bd18"), "This kit include a collapsible fishing pole, fishhooks, line, lures, and a fishing net.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("2d68801f-8232-453d-babc-bf83a4e6fab7"),
                Name = "Fishing Tackle",
                Hands = "2",
                Level = 0,
                Price = 80,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("d542a4a9-c904-4f82-a535-381329b4378d"),
                Name = "Fishing Tackle (Professional)",
                Hands = "2",
                Level = 3,
                Price = 2000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("b47f7551-67cd-4b63-b50f-0e9feb12bc85"), "Professional fishing tackle grants a +1 item bonus to checks to fish.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f62d0ad-0edc-4537-97d7-517bae0d0072"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
