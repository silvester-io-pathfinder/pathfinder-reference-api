using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class AlignmentSeeder : IEntitySeeder<Alignment>
    {
        public IEnumerable<Alignment> GetSeedEntities()
        {
            yield return new Alignment { Id = Guid.Parse("2006ffe6-8a03-4d40-99ac-935d814140ec"), Name = "Lawful Good" };
            yield return new Alignment { Id = Guid.Parse("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), Name = "Neutral Good" };
            yield return new Alignment { Id = Guid.Parse("add12009-9c8a-4287-b02b-7e5b9459bf44"), Name = "Chaotic Good" };
            yield return new Alignment { Id = Guid.Parse("2ad80bbd-a735-4431-9e3a-f784e053b756"), Name = "Chaotic Neutral" };
            yield return new Alignment { Id = Guid.Parse("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), Name = "Lawful Neutral" };
            yield return new Alignment { Id = Guid.Parse("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), Name = "True Neutral" };
            yield return new Alignment { Id = Guid.Parse("54f32060-3da3-4edf-b6dc-3839b8b7415d"), Name = "Lawful Evil" };
            yield return new Alignment { Id = Guid.Parse("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), Name = "Neutral Evil" };
            yield return new Alignment { Id = Guid.Parse("25f9299a-9a7c-40bc-b8bd-58588d19381b"), Name = "Chaotic Evil" };
        }
    }
}
