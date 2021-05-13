using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Structure : Template
    {
        public static readonly Guid ID = Guid.Parse("e486b7fc-a21d-4f12-a691-e5e3e712c095");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Structure",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("572d5892-ec13-4d46-b767-1ecacdc3cc42"), Type = TextBlockType.Text, Text = "An item with the structure trait creates a magical building or other structure when activated. The item must be activated on a plot of land free of other structures. The structure adapts to the natural terrain, adopting the structural requirements for being built there. The structure adjusts around small features such as ponds or spires of rock, but it can’t be created on water or other nonsolid surfaces. If activated on snow, sand dunes, or other soft surfaces with a solid surface underneath, the structure’s foundation (if any) reaches the solid ground. If an item with this trait is activated on a solid but unstable surface, such as a swamp or an area plagued by tremors, roll a DC 3 flat check each day; on a failure, the structure begins to sink or collapse." };
            yield return new TextBlock { Id = Guid.Parse("84215598-6cf7-4f12-b308-ab87014fbec5"), Type = TextBlockType.Text, Text = "The structure doesn’t harm creatures within the area when it appears, and it can’t be created within a crowd or in a densely populated area. Any creature inadvertently caught inside the structure when the item is activated ends up unharmed inside the complete structure and always has a clear path of escape. A creature inside the structure when the activation ends isn’t harmed, and it lands harmlessly on the ground if it was on an upper level of the structure." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8e7d05b-9515-4208-ad7c-201ce39e4637"),
                SourceId = CoreRulebook.ID,
                Page = 596
            };
        }
    }
}
