using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class ObservantHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("cbaec7eb-4492-42a3-83ac-1e82a5658fb8");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Observant Halfling", 
                Description = "Your finely honed senses quickly clue you in to danger or trickery. You gain a +1 circumstance bonus to your Perception DC, though not to your Perception checks." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Halfling.ID;
        }
    }
}
