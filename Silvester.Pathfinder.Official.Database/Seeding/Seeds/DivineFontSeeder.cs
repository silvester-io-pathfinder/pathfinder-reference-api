using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class DivineFontSeeder : IEntitySeeder<DivineFont>
    {
        public IEnumerable<DivineFont> GetSeedEntities()
        {
            yield return new DivineFont { Id = Guid.Parse("90698ae0-eb7f-49f2-b485-d7a1f9baf653"), Name = "Heal" };
            yield return new DivineFont { Id = Guid.Parse("f724073c-4395-4f57-91ff-21fca4f0a6be"), Name = "Harm" };
        }
    }
}
