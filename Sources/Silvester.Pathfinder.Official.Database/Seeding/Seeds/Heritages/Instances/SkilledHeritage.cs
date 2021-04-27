using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class SkilledHeritage : AbstractHeritageTemplate
    {
        public static readonly Guid ID = Guid.Parse("fdf36b32-00b2-457f-9aca-aa9378c0f92e");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Skilled Heritage", 
                Description = "Your ingenuity allows you to train in a wide variety of skills. You become trained in one skill of your choice. At 5th level, you become an expert in the chosen skill." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Human.ID;
        }
    }
}
