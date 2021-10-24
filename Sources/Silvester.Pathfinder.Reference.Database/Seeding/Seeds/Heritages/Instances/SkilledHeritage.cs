using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SkilledHeritage : Template
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

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Human.ID;
        }
    }
}
