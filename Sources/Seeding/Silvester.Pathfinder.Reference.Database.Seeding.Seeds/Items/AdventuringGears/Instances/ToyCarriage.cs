using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class ToyCarriage : Template
    {
        public static readonly Guid ID = Guid.Parse("0d5ac984-29be-45d5-95c8-54f5978b7e1b");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Toy Carriage",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c58792f5-f3a8-4cb5-bd91-a4e7883e28bc"), "A miniature toy carriage is carved from wood and has fully functioning wheels. It can vary in size from 2 to 8 inches long, too small for even Tiny creatures to ride. If pushed or propelled, obstacles and terrain might slow, stop, tip, or divert the carriage's course.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b919f143-01e6-4a54-bdf2-3c1ed78bb564"),
                Name = "Toy Carriage",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 0,
                Price = 50,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("e8f6c43a-de03-4166-b89a-533fe77bd6bd"), "If pushed and released as an Interact action, a toy carriage rolls along the ground up to 20 feet.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("3e58e181-7866-4e50-939f-694feb782d42"),
                Name = "Toy Carriage (Windup)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 2,
                Price = 500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("a8dba529-e07a-44c8-990b-5d163c1d0d22"), "A tiny crank protrudes from the side of this carriage. If the crank is wound and the carriage is released on the ground, the carriage propels in a straight line at a Speed of 10 feet. Each Interact action spent winding the crank propels the carriage for 1 round. A windup toy carriage can be wound for a maximum of 9 actions total, at which point it's too tight to wind further.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("196bdc83-691e-409f-b711-724b21a2805f"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 59
            };
        }
    }
}
