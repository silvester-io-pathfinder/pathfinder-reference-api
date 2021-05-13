using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class WildwoodHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("0b36fe08-7970-45a3-a816-05d187ae1709");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Wildwood Halfling", 
                Description = "You hail from deep in a jungle or forest, and you’ve learned how to use your small size to wriggle through undergrowth, vines, and other obstacles. You ignore difficult terrain from trees, foliage, and undergrowth." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Halfling.ID;
        }
    }
}
