using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class SavingThrowStatSeeder : IEntitySeed<SavingThrowStat>
    {
        public IEnumerable<SavingThrowStat> GetSeedEntities()
        {
            yield return new SavingThrowStat { Id = Guid.Parse("83f532a1-dad3-4dc8-b13d-77e69959444a"), Name = "Fortitude" };
            yield return new SavingThrowStat { Id = Guid.Parse("5048e38a-a47c-4832-b37f-fd3818eced35"), Name = "Reflex" };
            yield return new SavingThrowStat { Id = Guid.Parse("a71929b0-9dff-492a-9bf9-8f9cadda198c"), Name = "Will" };
        }
    }
}
