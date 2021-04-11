using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class HazardComplexitySeeder : IEntitySeeder<HazardComplexity>
    {
        public IEnumerable<HazardComplexity> GetSeedEntities()
        {
            yield return new HazardComplexity { Id = Guid.Parse("bac94513-a759-47b1-843f-3acb4946e83b"), Name = "Simple" };
            yield return new HazardComplexity { Id = Guid.Parse("dcc2b25e-1b95-401a-8fc6-17f1e1ee7cbb"), Name = "Complex" };
        }
    }
}
