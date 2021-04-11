using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class AlchemicalToolPotencySeeder : IEntitySeeder<AlchemicalToolPotency>
    {
        public IEnumerable<AlchemicalToolPotency> GetSeedEntities()
        {
            yield return new AlchemicalToolPotency { Id = Guid.Parse("791041b0-b374-431b-9ad5-439e3a6b970e"), Name = "Lesser" };
            yield return new AlchemicalToolPotency { Id = Guid.Parse("4d437e81-f1e6-477c-8811-e793c6747160"), Name = "Greater" };
        }
    }
}
