using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class ArmorGroupSeeder : IEntitySeeder<ArmorGroup>
    {
        public IEnumerable<ArmorGroup> GetSeedEntities()
        {
            yield return new ArmorGroup { Id = Guid.Parse("3e53fcd2-e07b-4af5-b331-b4372acacf74"), Name = "Unarmored" };
            yield return new ArmorGroup { Id = Guid.Parse("f3d2b25b-e222-4af2-9287-a6036e6bb0b7"), Name = "Heavy Armor" };
            yield return new ArmorGroup { Id = Guid.Parse("199f2e7d-5249-45ee-af4d-b3f7cdd257b8"), Name = "Medium Armor" };
            yield return new ArmorGroup { Id = Guid.Parse("28f6b905-0c5e-4cc0-8164-8e623fdfb367"), Name = "Light Armor" };
        }
    }
}
