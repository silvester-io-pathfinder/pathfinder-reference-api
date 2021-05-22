using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class TreedwellerGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("35e10760-e9f1-4570-89f6-7fd2c3ecee42");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Treedweller Goblin", 
                Description = "You have adapted particularly well to living in forested environments. As long as you are in a forest or jungle, you gain a +2 circumstance bonus to Stealth checks to Hide and Sneak, Survival checks to Subsist, and your Survival DC to Cover Tracks." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Goblin.ID;
        }
    }
}
