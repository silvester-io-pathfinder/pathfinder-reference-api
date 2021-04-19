using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class DamageTypeSeeder : IEntitySeed<DamageType>
    {
        public IEnumerable<DamageType> GetSeedEntities()
        {
            yield return new DamageType { Id = Guid.Parse("4712d8c3-ffe6-4db2-b28e-f94065b005bc"), Name = "Bludgeoning" };
            yield return new DamageType { Id = Guid.Parse("8095023e-8d92-4cdd-b294-846dc71fdb21"), Name = "Piercing" };
            yield return new DamageType { Id = Guid.Parse("d047f71a-eead-4685-b09c-03e11ad29d8b"), Name = "Slashing"};
            yield return new DamageType { Id = Guid.Parse("b084d3bf-72ac-49bc-bab2-21aa86c31fd2"), Name = "Bleed"};
            yield return new DamageType { Id = Guid.Parse("b10f2804-9573-4bbf-a11d-aeff35f6b816"), Name = "Fire"};
            yield return new DamageType { Id = Guid.Parse("4b4b2444-718f-4f96-a4df-c1a3cfddf263"), Name = "Electricity" };
            yield return new DamageType { Id = Guid.Parse("38834ac6-9f9f-4b44-ad45-c2c932ff4b27"), Name = "Poison" };
            yield return new DamageType { Id = Guid.Parse("d88d0bfa-b079-4ac3-8978-2c65208981ca"), Name = "Negative" };
            yield return new DamageType { Id = Guid.Parse("ce414c75-a03c-4602-a0e0-8d81ac980fc5"), Name = "Other"};
        }
    }
}
