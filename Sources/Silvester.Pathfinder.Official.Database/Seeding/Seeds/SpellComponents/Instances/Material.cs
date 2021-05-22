using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SpellComponents.Instances
{
    public class Material : Template
    {
        public static readonly Guid ID = Guid.Parse("4a9cf550-0cb7-4df1-8519-45765fc23af3");

        public override SpellComponent GetSpellComponent()
        {
            return new SpellComponent
            {
                Id = ID,
                Name = "Material",
                Description = "A material component is a bit of physical matter consumed in the casting of the spell. The spell gains the manipulate trait and requires you to have a free hand to retrieve and manipulate a material component. That component is expended in the casting (even if the spell is disrupted). Except in extreme circumstances, you can assume all common components are included in a material component pouch."
            };
        }
    }
}
