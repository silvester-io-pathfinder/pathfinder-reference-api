using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class ElementalHeartDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("801fba4a-dd78-4f76-beca-ff51faac7b7a");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Elemental Heart Dwarf", 
                Description = "Whether through a connection to Torag’s forge, the azers of the Plane of Fire, or another source, you can exude a burst of energy. Mbe’ke and Taralu dwarves of the Mwangi Expanse believe this heritage is a gift from dragons or elemental spirits. Choose one of the following damage types: acid, cold, electricity, or fire. Once chosen, this can’t be changed. You gain the Energy Emanation activity." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Dwarf.ID;
        }
    }
}
