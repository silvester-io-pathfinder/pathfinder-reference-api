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
    public class DepthGauge : Template
    {
        public static readonly Guid ID = Guid.Parse("4167d470-b6fb-40e1-826f-e3ff02ae8732");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Depth Gauge",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d3a01d58-9cd0-4eb5-b585-042eb605c6a4"), "This simple tool consists of a small iron weight attached to a thin rope that is marked at regular intervals (typically every foot). It can be used to measure the depth of a hole or body of water by dropping the weight down into unknown depths and counting the markings on the rope. It can also be used as a plumb bob.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("edfac49d-442a-4e5e-895b-752a21ddbc5c"),
                Name = "Depth Gauge",
                Level = 0,
                Hands = "2",
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e46d003-82e0-48d4-993d-f4b1d8e4b779"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 114
            };
        }
    }
}
