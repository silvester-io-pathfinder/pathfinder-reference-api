using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class ConditionCategorySeeder : IEntitySeed<ConditionCategory>
    {
        public IEnumerable<ConditionCategory> GetSeedEntities()
        {
            yield return new ConditionCategory{ Id = Guid.Parse("ae1f94c2-5442-4eed-bfdc-54a3faadbcc4"), Name = "Attitudes"};
            yield return new ConditionCategory{ Id = Guid.Parse("18744a3c-8c8d-4298-8be7-f5e7e5dc0a6b"), Name = "Death and Dying"};
            yield return new ConditionCategory{ Id = Guid.Parse("d104a1f4-fb11-45c3-84b7-14880d673095"), Name = "Degrees of Detection"};
            yield return new ConditionCategory{ Id = Guid.Parse("655ed530-4d75-4816-af14-4cbbdd19531e"), Name = "Lowered Abilities"};
            yield return new ConditionCategory{ Id = Guid.Parse("224d0ea9-af56-49b9-946d-ce809b894701"), Name = "Senses"};
        }
    }
}
