using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Ball : Template
    {
        public static readonly Guid ID = Guid.Parse("a98cbcee-bfac-40e1-ae27-ee2d26ee33e8");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Ball",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8cccd449-89f0-4166-9da9-6cc418807138"), "Toy balls come in a variety of shapes, sizes, and compositions, such as with squishy fabric, bouncy rubber, or lightweight wicker, or forms like bean-filled sacks and hard-hide balls.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4aee212d-979c-4e05-97c8-3fcb07a8f066"),
                Name = "Ball",
                Usage = "Held in 1 hand.",
                Level = 0,
                Hands = "1",
                Price = 3,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("52abdc73-fc43-46b3-ae76-14396b3a025c"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 58
            };
        }
    }
}
