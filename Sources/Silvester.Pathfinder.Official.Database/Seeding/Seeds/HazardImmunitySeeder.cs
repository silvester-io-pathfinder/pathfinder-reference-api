using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class HazardImmunitySeeder : IEntitySeed<HazardImmunity>
    {
        public IEnumerable<HazardImmunity> GetSeedEntities()
        {
            yield return new HazardImmunity { Id = Guid.Parse("7bbfc8dc-05c1-49f6-938d-07eb81d7ad83"), Name = "Critical Hits" };
            yield return new HazardImmunity { Id = Guid.Parse("b4be6e7f-41de-4943-b277-9fff8f56a398"), Name = "Object Immunities" };
            yield return new HazardImmunity { Id = Guid.Parse("d9423d3e-cf11-4bd0-9789-89dd60fe61b0"), Name = "Precision Damage" };
        }
    }
}
