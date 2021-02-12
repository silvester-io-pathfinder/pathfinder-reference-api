using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class SourceSeeder : IEntitySeeder<Source>
    {
        public IEnumerable<Source> GetSeedEntities()
        {
            yield return new Source { Id = Guid.Parse("4e85ec44-4a72-4bea-a3e5-5e6d88882d75"), Name = "Core Rulebook" };
            yield return new Source { Id = Guid.Parse("979e79d5-05ab-4c2f-b8eb-872f89367ddc"), Name = "Advanced Rulebook" };
            yield return new Source { Id = Guid.Parse("f81a5e37-0ec8-443d-924b-75769a2d321b"), Name = "Custom" };
        }
    }
}
