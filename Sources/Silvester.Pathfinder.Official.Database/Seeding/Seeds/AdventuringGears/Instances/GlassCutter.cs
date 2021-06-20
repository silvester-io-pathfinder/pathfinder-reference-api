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
    public class GlassCutter : Template
    {
        public static readonly Guid ID = Guid.Parse("783370e3-5de6-4fb7-8bf2-6b1ea444727d");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Glass Cutter",
                Hands = "2",
                Price = 500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2deb8586-5120-45bf-ad34-d01af497b2a8"), Type = TextBlockType.Text, Text = "This small rod has a tiny, sharp cutting wheel made of steel on one end and a thick bulb on the other. You can use the glass cutter's wheel to score ordinary glass and use the bulb to break the piece along your scoring. It typically takes 1 minute of work to cut a hole large enough to fit your hand. If you are attempting to break the glass quietly, you must attempt a Thievery check against the Perception DC of nearby creatures to go unnoticed." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2d2dfe5-b1dc-4be9-8335-fedd3ab8d24f"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 115
            };
        }
    }
}
