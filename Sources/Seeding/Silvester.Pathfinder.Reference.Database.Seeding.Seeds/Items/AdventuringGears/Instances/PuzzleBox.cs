using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class XXTemplate : Template
    {
        public static readonly Guid ID = Guid.Parse("c4488b6b-3ed1-4719-989e-e25554b6714f");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Puzzle Box",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b76c7f76-01de-4fed-9488-8f4a0419bb14"), "A puzzle box features moving parts, locking mechanisms, and other components designed to confound the user. Solving a puzzle box typically requires three successful Games Lore or Thievery checks to Open a Lock, though puzzle boxes come in countless configurations and themes, and the GM can determine which skills are appropriate.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("abe8a115-bcab-415d-a781-4510650e6d27"),
                Name = "Puzzle Box (Simple)",
                Hands = "1",
                Level = 0,
                Price = 20,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("cd822614-6275-4d56-aa24-62a5bd3d493c"), "The DC to solve this puzzle box is 15.")
                    .Build()
            }; 
            
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("d8293650-8b67-491d-9be5-4c2f0f2fb2bb"),
                Name = "Puzzle Box (Complex)",
                Level = 1,
                Price = 200,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                  .Text(Guid.Parse("c4be311a-1394-4c15-a024-3bd9ca5bc912"), "The DC to solve this puzzle box is 20.")
                  .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("bc18a5f4-e7c2-4ab4-b9f2-068ff0401554"),
                Name = "Puzzle Box (Challenging)",
                Level = 3,
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                 .Text(Guid.Parse("7f66aa1e-8497-4eb7-a3f8-7aaf6f53da48"), "The DC to solve this puzzle box is 25.")
                 .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("667f3251-7940-4a1a-b53d-daef347708c0"),
                Name = "Puzzle Box (Hollow)",
                Level = 0,
                Price = 0,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                 .Text(Guid.Parse("fe19fdca-5d28-4f27-8710-9b77b0e412c2"), "A hollow puzzle box is designed to have an empty compartment in its center, allowing you to hide an object inside of the box. Only someone that solves the puzzle box can access the item within. A hollow puzzle box can hold an item of negligible Bulk no larger than 1 inch in diameter. Any puzzle box can be made into a hollow puzzle box. Doing so doubles the puzzle box's price.")
                 .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1ed148d-400d-4e8e-a737-891013a15249"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 59
            };
        }
    }
}
