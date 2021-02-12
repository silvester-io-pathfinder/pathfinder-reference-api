using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class FeatTypeSeeder : IEntitySeeder<FeatType>
    {
        public IEnumerable<FeatType> GetSeedEntities()
        {
            yield return new FeatType { Id = Guid.Parse("c15fb53a-0b27-47c1-8ef4-eba2d982075c"), Name = "Heritage" };
            yield return new FeatType { Id = Guid.Parse("58ef6c11-b8bd-411e-8222-6434fa491d11"), Name = "General" };
            yield return new FeatType { Id = Guid.Parse("cc6e0f95-a0f4-4521-9c53-7f3484be3530"), Name = "Class" };
        }
    }
}
