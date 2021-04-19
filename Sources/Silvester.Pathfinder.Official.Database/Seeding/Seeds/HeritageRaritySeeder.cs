using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class HeritageRaritySeeder : IEntitySeed<HeritageRarity>
    {
        public IEnumerable<HeritageRarity> GetSeedEntities()
        {
            yield return new HeritageRarity { Id = Guid.Parse("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807"), Name = "Common" };
            yield return new HeritageRarity { Id = Guid.Parse("7eb0082a-50c0-44ef-a990-7aae6cb9cf27"), Name = "Uncommon" };
            yield return new HeritageRarity { Id = Guid.Parse("6ccbbd83-6da1-488b-9a1f-9a658fcdbd84"), Name = "Rare" };
            yield return new HeritageRarity { Id = Guid.Parse("8def5893-8645-4396-9692-cebfad1ea649"), Name = "Unique" };
        }
    }
}
