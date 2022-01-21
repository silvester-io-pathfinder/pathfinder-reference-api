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
    public class SnareKit : Template
    {
        public static readonly Guid ID = Guid.Parse("9262e9cf-8696-45b1-9612-88a1a91fd7cc");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Snare Kit",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("97e6acf4-927d-48af-bc1f-2771b9f6a96b"), "This kit contains tools and materials for creating snares. A snare kit allows you to Craft snares using the Crafting skill. You can draw and replace a worn snare kit as part of the action to use it.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("5003d110-44bc-4519-b8c0-4c708c29989c"),
                Name = "Snare Kit",
                Hands = "2",
                Level = 0,
                Price = 500,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("eada8c43-dde1-4148-8b1f-5694548241d2"),
                Name = "Specialist",
                Hands = "2",
                Level = 3,
                Price = 5500,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("40f99179-1a79-4027-94fd-1c54494e5831"), "A specialist snare kit gives you a +1 item bonus to the check.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0bfeaa91-39df-41f1-93fd-fa007f9e4617"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
