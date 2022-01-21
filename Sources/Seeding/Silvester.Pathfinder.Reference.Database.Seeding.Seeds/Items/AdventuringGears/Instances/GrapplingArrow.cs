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
    public class GrapplingArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("0bb0ef67-0618-4537-9772-fcb3e22c83af");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Grappling Arrow",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("2ff0b4c1-8895-462d-a784-386dcd22387c"), "This small grappling hook is designed to be tied to a rope and fired from a bow. When fired, it has half the normal range increment for the weapon.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0dd03b50-5a13-4c1e-89e1-e48814ab267d"),
                Name = "Grappling Arrow",
                Hands = "1",
                Level = 0,
                Price = 20,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df8529d1-4ece-4ebc-9774-9d16b4ff6032"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 115
            };
        }
    }
}
