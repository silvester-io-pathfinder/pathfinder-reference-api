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
    public class SturdyStachel : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("a22483eb-0db6-4677-9097-babb09ab0460");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Sturdy Stachel",
                Hands = "0",
                ItemLevel = "2",
                Price = 3000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9575701a-4c38-4ee0-bd43-9f6291ca9b2f"), Type = TextBlockType.Text, Text = "This heavy backpack of alchemically treated cloth layered over a metal mesh protects its contents from water damage and other harmful effects. It holds up to 4 Bulk of items, and the first 2 Bulk contained within the sturdy satchel do not count against your Bulk limits. The bag has Hardness 5 and 20 Hit Points. As long as the bag remains closed and is not broken, water and other liquids can't seep into it." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("807943a9-5e22-48b3-b3d9-54a747232a65"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 34
            };
        }
    }
}
