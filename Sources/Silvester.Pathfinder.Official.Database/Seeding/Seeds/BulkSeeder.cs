using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class BulkSeeder : IEntitySeeder<Bulk>
    {
        public IEnumerable<Bulk> GetSeedEntities()
        {
            yield return new Bulk { Id = Guid.Parse("b5de3410-d051-4dfe-be54-dde62ee45bc1"), Name = "-", BulkWeight = 0, LightWeight = 0 };
            yield return new Bulk { Id = Guid.Parse("978d32f8-10b7-4150-bd9f-b8f037220542"), Name = "L", BulkWeight = 0, LightWeight = 1 };
            yield return new Bulk { Id = Guid.Parse("8ad6f1e7-1ac2-47fd-b374-bb4f077a2545"), Name = "1", BulkWeight = 1, LightWeight = 0 };
            yield return new Bulk { Id = Guid.Parse("28310eb8-9bee-46f0-9b93-e0965207169a"), Name = "2", BulkWeight = 2, LightWeight = 0 };
            yield return new Bulk { Id = Guid.Parse("d09af7fc-06b3-41c5-89f7-7cbb3fb6f93b"), Name = "3", BulkWeight = 3, LightWeight = 0 };
            yield return new Bulk { Id = Guid.Parse("61e784de-dd93-4d53-acda-61dff663e2a3"), Name = "4", BulkWeight = 4, LightWeight = 0 };
        }
    }
}
