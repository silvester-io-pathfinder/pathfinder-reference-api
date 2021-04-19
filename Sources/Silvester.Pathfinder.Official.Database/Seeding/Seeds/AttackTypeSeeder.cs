using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class AttackTypeSeeder : IEntitySeed<AttackType>
    {
        public IEnumerable<AttackType> GetSeedEntities()
        {
            yield return new AttackType { Id = Guid.Parse("1a61a928-f75d-4c1e-b655-b92a9d40bc77"), Name = "Melee" };
            yield return new AttackType { Id = Guid.Parse("4f46c206-80e8-4ff2-a3dd-e4d6a73b5388"), Name = "Ranged" };
        }
    }
}
