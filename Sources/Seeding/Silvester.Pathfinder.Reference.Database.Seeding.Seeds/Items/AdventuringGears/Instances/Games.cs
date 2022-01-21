using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Games : Template
    {
        public static readonly Guid ID = Guid.Parse("198fcd84-3e1d-4930-8c95-56bc88242835");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Games",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ec44faf8-ae43-40f0-bd40-fc9b8d882e8b"), "A nigh-infinite assortment of games exist in Golarion. Simple games, including dice, a deck of cards, or dominoes, cost 5 sp. Board games vary in cost from 1 gp for dexterity games like Bungle, 3 gp for colorful children's games like Cauldron Quest, and 5 gp for complex strategy games like Kingmaker and Abendego Raiders. Lavish game sets can cost much more than these prices, as they are made of expensive components and are intricately crafted works of art unto themselves.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("7aa356cb-165c-45cf-8a7c-ad1f009b376a"),
                Name = "Games (Dice)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 0,
                Price = 50,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b386e73c-2c41-4019-8310-8c4e0d2b0f92"),
                Name = "Games (Deck of Cards)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 0,
                Price = 50,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("76d6a622-f2d7-4290-8b8c-0c93a44a59ed"),
                Name = "Games (Dominoes)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 0,
                Price = 50,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("57b24744-dbe1-42a3-b732-47d62fcc0959"),
                Name = "Games (Bungle)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 0,
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("5255d467-065a-4580-92a1-fbf376e1b8ce"),
                Name = "Games (Cauldron Quest)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 0,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("7475927d-8395-4069-a63d-656e58e59ceb"),
                Name = "Games (Kingmaker)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 0,
                Price = 500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("1db57903-4f12-4376-8765-987f62cb3542"),
                Name = "Games (Abendego Raiders)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 0,
                Price = 500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("3bb20897-9e14-4805-a1e8-17cd9d1e872b"),
                Name = "Games (Loaded Dice)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 1,
                Price = 500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("261071ce-c742-4063-94a7-fae909ad3e6c"), "These dice are weighted on one side to ensure they always land with the desired number facing up. Loaded dice grant you a +1 item bonus to Games Lore checks to gamble with the dice. You can determine a die is loaded while handling it with a successful secret DC 20 Perception check. Determining dice are loaded without handling the dice is more difficult, especially since smart cheaters switch loaded dice in and out so they don't suspiciously roll the same number over and over. In this case, an observer must succeed at a secret Perception check against the roller's Games Lore or Thievery DC to notice the switches or the patterns.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3bc0e833-73a9-4c70-9b97-43ac5014305b"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 58 
            };
        }
    }
}
