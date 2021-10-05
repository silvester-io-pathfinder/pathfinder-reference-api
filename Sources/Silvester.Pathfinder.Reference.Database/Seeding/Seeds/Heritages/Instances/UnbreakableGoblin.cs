using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class UnbreakableGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("634935e2-14bd-4de5-b1d9-fcff13093d94");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Unbreakable Goblin", 
                Description = "You’re able to bounce back from injuries easily due to an exceptionally thick skull, cartilaginous bones, or some other mixed blessing. You gain 10 Hit Points from your ancestry instead of 6. When you fall, reduce the falling damage you take as though you had fallen half the distance." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Goblin.ID;
        }
    }
}
