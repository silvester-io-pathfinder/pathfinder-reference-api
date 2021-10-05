using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class GrapplingBolt : Template
    {
        public static readonly Guid ID = Guid.Parse("bdec1ae5-66cd-40ab-8761-5ce6ba1eb9f1");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Grappling Bolt",
                Hands = "1",
                Price = 20,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ef46aa6a-f84f-44d8-b248-c1d47c7d237f"), Type = TextBlockType.Text, Text = "This small grappling hook is designed to be tied to a rope and fired from a crossbow. When fired, it has half the normal range increment for the weapon." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79c70f5f-b3a1-42b8-b8b7-e043d23344ce"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 115
            };
        }
    }
}
