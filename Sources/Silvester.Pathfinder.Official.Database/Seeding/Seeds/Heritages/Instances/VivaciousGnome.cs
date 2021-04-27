using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class VivaciousGnome : AbstractHeritageTemplate
    {
        public static readonly Guid ID = Guid.Parse("0bde2b22-b4ee-484d-9052-6c4b47488624");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Vivacious Gnome", 
                Description = "You have an incredibly strong connection to the positive energy that flows through the First World, making it harder to attack your life force with negative energy. You gain negative resistance equal to half your level (minimum 1). When you have the doomed condition, the condition affects you as if its value was 1 lower than it actually is (doomed 1 has no effect, doomed 2 causes you to die at dying 3, and so on)." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Gnome.ID;
        }
    }
}
