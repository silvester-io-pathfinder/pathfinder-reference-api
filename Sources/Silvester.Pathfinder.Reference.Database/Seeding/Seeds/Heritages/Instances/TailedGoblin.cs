using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class TailedGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("4a851a94-b9dd-4afe-b74e-4c3ef1407d9f");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Tailed Goblin", 
                Description = "You have a powerful tail, likely because you descend from a community of monkey goblins. You gain a +2 circumstance bonus to Athletics checks to Climb, you gain Combat Climber as a bonus feat, and you reduce the number of free hands required to Climb or Trip by one." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Goblin.ID;
        }
    }
}
