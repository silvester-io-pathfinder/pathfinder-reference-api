using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class BenefitTypeSeeder : IEntitySeeder<BenefitType>
    {
        public IEnumerable<BenefitType> GetSeedEntities()
        {
            yield return new BenefitType { Id = Guid.Parse("2cf97405-0831-45eb-a8e9-6c732079dd37"), Name = "Assurance" };
        }
    }
}
