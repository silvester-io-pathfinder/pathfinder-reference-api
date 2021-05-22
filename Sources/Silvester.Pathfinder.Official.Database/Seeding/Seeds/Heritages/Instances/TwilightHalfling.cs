using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class TwilightHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("a8c3e70e-6eb6-4a5e-85cd-755eccc7677e");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Twilight Halfling", 
                Description = "Your ancestors performed many secret acts under the concealing cover of dusk, whether for good or ill, and over time they developed the ability to see in twilight beyond even the usual keen sight of halflings. You gain low-light vision." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Halfling.ID;
        }
    }
}
