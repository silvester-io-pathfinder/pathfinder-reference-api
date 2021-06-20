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
    public class HarrowCarryingCase : Template
    {
        public static readonly Guid ID = Guid.Parse("0f0bf997-7653-4941-af5f-375d4f5786a3");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Harrow Carrying Case",
                Hands = "1",
                Price = 100,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4fd60da6-f092-412a-9481-c5583ba16d35"), Type = TextBlockType.Text, Text = "This elegant wooden case contains a recessed section to hold a simple or common harrow deck and a harrow mat. The case features a watertight seal to protect its contents from the elements and everyday wear and tear." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a7ed5c0c-f9d3-4672-b084-b24ffea26ce1"),
                SourceId = Pathfinder160.ID,
                Page = 66
            };
        }
    }
}
