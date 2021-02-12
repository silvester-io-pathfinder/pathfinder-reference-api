using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class RaceSizeSeeder : IEntitySeeder<RaceSize>
    {
        public IEnumerable<RaceSize> GetSeedEntities()
        {
            yield return new RaceSize { Id = Guid.Parse("f44c1295-604f-443b-9ecc-870d82264eb5"), Name = "Tiny", Space = 3, BreadthReach = 0, HeightReach = 0 };
            yield return new RaceSize { Id = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2"), Name = "Small", Space = 5, BreadthReach = 5, HeightReach = 5 };
            yield return new RaceSize { Id = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991"), Name = "Medium", Space = 5, BreadthReach = 5, HeightReach = 5 };
            yield return new RaceSize { Id = Guid.Parse("abe0e587-0fda-48d3-9206-1d43e727bcab"), Name = "Large", Space = 10, BreadthReach = 10, HeightReach = 5 };
            yield return new RaceSize { Id = Guid.Parse("eba80c08-8f5b-4dee-8d43-f1aa5fc30d8b"), Name = "Huge", Space = 15, BreadthReach = 15, HeightReach = 20 };
            yield return new RaceSize { Id = Guid.Parse("93daa531-f40c-4db8-8cc2-65f8e32b951b"), Name = "Gargantuan", Space = 20, BreadthReach = 20, HeightReach = 15 };
        }
    }
}