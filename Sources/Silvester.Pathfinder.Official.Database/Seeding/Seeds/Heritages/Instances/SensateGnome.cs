using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class SensateGnome : AbstractHeritageTemplate
    {
        public static readonly Guid ID = Guid.Parse("d4c74254-f221-41a2-b2b9-2d8ad741cbc0");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Sensate Gnome", 
                Description = "You see all colors as brighter, hear all sounds as richer, and especially smell all scents with incredible detail. You gain a special sense: imprecise scent with a range of 30 feet. This means you can use your sense of smell to determine the exact location of a creature. The GM will usually double the range if you're downwind from the creature or halve the range if you're upwind. In addition, you gain a + 2 circumstance bonus to Perception checks whenever you're trying to locate an undetected creature that is within the range of your scent." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Gnome.ID;
        }
    }
}
