using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class FrequencySeeder : IEntitySeed<Frequency>
    {
        public IEnumerable<Frequency> GetSeedEntities()
        {
            yield return new Frequency { Id = Guid.Parse("e1160af3-7dae-49e2-bacf-2d558be08fd6"), Name = "Once per day.", Amount = 1, TimeSpan = TimeSpan.FromDays(1)};
            yield return new Frequency { Id = Guid.Parse("effdc3c2-b381-4a3b-883c-12c9e9479878"), Name = "Once per hour.", Amount = 1, TimeSpan = TimeSpan.FromHours(1) };
            yield return new Frequency { Id = Guid.Parse("6d3d62d7-9630-4933-9db4-983720eb6042"), Name = "Twice per day.", Amount = 2, TimeSpan = TimeSpan.FromDays(1) };
            yield return new Frequency { Id = Guid.Parse("7d26de34-8d31-4b00-8ce8-3d2712c2ee3d"), Name = "Once per round.", Amount = 1, TimeSpan = TimeSpan.FromSeconds(6) };
            yield return new Frequency { Id = Guid.Parse("aa64b0f6-fb62-4af8-bba8-a174f19a1b73"), Name = "Once per ten minutes.", Amount = 1, TimeSpan = TimeSpan.FromMinutes(10) };
        }
    }
}
