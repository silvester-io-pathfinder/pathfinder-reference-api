using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Structure : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Trait GetTrait(TraitSeeder seeder)
        {
            return new Trait
            {
                Id = ID,
                Name = "Structure",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "An item with the structure trait creates a magical building or other structure when activated. The item must be activated on a plot of land free of other structures. The structure adapts to the natural terrain, adopting the structural requirements for being built there. The structure adjusts around small features such as ponds or spires of rock, but it can’t be created on water or other nonsolid surfaces. If activated on snow, sand dunes, or other soft surfaces with a solid surface underneath, the structure’s foundation (if any) reaches the solid ground. If an item with this trait is activated on a solid but unstable surface, such as a swamp or an area plagued by tremors, roll a DC 3 flat check each day; on a failure, the structure begins to sink or collapse." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The structure doesn’t harm creatures within the area when it appears, and it can’t be created within a crowd or in a densely populated area. Any creature inadvertently caught inside the structure when the item is activated ends up unharmed inside the complete structure and always has a clear path of escape. A creature inside the structure when the activation ends isn’t harmed, and it lands harmlessly on the ground if it was on an upper level of the structure." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = CoreRulebook.ID,
                Page = 596
            };
        }
    }
}
