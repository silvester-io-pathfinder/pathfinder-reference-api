using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class MagneticConstructionSet : Template
    {
        public static readonly Guid ID = Guid.Parse("f70fb99d-9152-4099-b39a-6ba4ca3edeb5");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Magnetic Construction Set"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d7edd3d5-57d2-4c99-8684-4efa89bbd05a"), "This collection of small magnets and metal rods comes in a wooden box. The magnets are strong enough to firmly cling to metal objects but too weak to move or suspend them. The metal rods are a quarter of an inch in diameter and vary in length from 3 to 6 inches. If connected with the magnets, these rods can be used to build flimsy shapes and structures, which collapse if external weight or pressure is applied.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("015cbbaa-c24e-4e01-b70b-ab4284aa3529"),
                Name = "Magnetic Construction Set",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 1,
                Price = 200,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31ec8307-0d47-49be-8986-77213cef9595"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 58
            };
        }
    }
}
