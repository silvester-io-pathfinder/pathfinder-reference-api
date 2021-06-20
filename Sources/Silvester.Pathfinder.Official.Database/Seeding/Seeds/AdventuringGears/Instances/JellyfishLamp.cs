using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class JellyfishLamp : Template
    {
        public static readonly Guid ID = Guid.Parse("16e8493f-7a41-495c-9cf4-c4ecc788d5f9");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Jellyfish Lamp",
                Hands = "1",
                Price = 200,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f0ddbeaf-7171-4f19-9897-745d636ecd50"), Type = TextBlockType.Text, Text = "These bioluminescent jellyfish are as bright as candles, come in a variety of colors, and can act as living lanterns. They dry up and die if removed from the water for more than 1 hour, but as long as they’re allowed access to seawater, they can usually survive for up to 1 year by feeding on micronutrients. Rarely, a well-treated jellyfish lamp might live longer and potentially develop stronger light or additional abilities." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("efa6156c-e0cd-4cd2-a693-c5391ad8f5d3"),
                SourceId = WorldGuide.ID,
                Page = 68
            };
        }
    }
}
