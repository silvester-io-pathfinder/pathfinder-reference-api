using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class WaterPurifier : Template
    {
        public static readonly Guid ID = Guid.Parse("0ff1b0d8-a30c-41ed-86b7-e56aec6d93fd");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Water Purifier",
                Hands = "2",
                Price = 500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1523eb79-8ae5-41ea-be4d-6c41c7143134"), Type = TextBlockType.Text, Text = "This small tube of metal and glass has an opening at one end into which water can be poured, leading to a series of interconnected chambers filled with purifying agents contained between various perforated walls. The purifier attempts to counteract poisons and other toxins present in water or any other liquid poured into it. Alchemically-treated replacement filters can be purchased to more effectively filter out more dangerous substances, using the filter's listed level as the counteract level." };
            yield return new TextBlock { Id = Guid.Parse("9b7aa45e-5267-4c5f-ac3e-571f6d998dd4"), Type = TextBlockType.Text, Text = "If you pour a liquid other than water, such as a potion or beverage, into the purifier, the filtration process negates the liquid's effects and ruins the taste. The center of the tube can be unscrewed from the ends to access and replace the chambers of purifying agents. Each filter can be used to cleanse up to 10 gallons of water at a rate of about 1 gallon every 20 minutes." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("45f2c06a-168d-42c1-9cf4-2b2b5361802e"),
                NameAddendum = "Level 1",
                DescriptionAddendum = "The counteract modifier is +5 for the level 1 filter.",
                ItemLevel = 1,
                Price = 500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("dccdf3d1-7c42-4d81-915e-538a42dfd0c4"),
                NameAddendum = "Level 5",
                DescriptionAddendum = "The counteract modifier is +9 for the level 5 filter.",
                ItemLevel = 5,
                Price = 2500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("5e0ac2ee-fcf5-4ec3-96da-dddf2dcef9e4"),
                NameAddendum = "Level 10",
                DescriptionAddendum = "The counteract modifier is +17 for the level 10 filter.",
                ItemLevel = 10,
                Price = 15500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8e483b7-3a9e-416f-ad2e-bb6e08e4ae4b"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 115
            };
        }
    }
}
