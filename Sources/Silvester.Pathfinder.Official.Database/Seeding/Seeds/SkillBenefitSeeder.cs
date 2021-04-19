using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class SkillBenefitTypeSeeder : IEntitySeed<BenefitType>
    {
        public IEnumerable<BenefitType> GetSeedEntities()
        {
            yield return new BenefitType { Id = Guid.Parse("a9d534a2-c1f7-4cee-baf6-79202e9d9c7b"), Name = "Assurance", };
        }
    }
}
