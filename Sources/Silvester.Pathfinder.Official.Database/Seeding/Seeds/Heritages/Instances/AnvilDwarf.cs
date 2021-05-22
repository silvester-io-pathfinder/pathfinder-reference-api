using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class AnvilDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("e019e11d-e494-49d6-8861-5c61a4768b6a");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Anvil Dwarf", 
                Description = "You are a descendant of a famed crafter and have your own amazing talent. Other dwarves might consider this a blessing from your ancestors or from the Forgefather himself, depending on where you grew up. You become trained in Crafting (or another skill if you were already trained in Crafting) and gain the Specialty Crafting skill feat, but you can pick two different specialties instead of one." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Dwarf.ID;
        }
    }
}
