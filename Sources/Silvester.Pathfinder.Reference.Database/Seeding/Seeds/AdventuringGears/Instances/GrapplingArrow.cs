using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
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
                Hands = "1",
                Price = 20,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2ff0b4c1-8895-462d-a784-386dcd22387c"), Type = TextBlockType.Text, Text = "This small grappling hook is designed to be tied to a rope and fired from a bow. When fired, it has half the normal range increment for the weapon." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df8529d1-4ece-4ebc-9774-9d16b4ff6032"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 115
            };
        }
    }
}
