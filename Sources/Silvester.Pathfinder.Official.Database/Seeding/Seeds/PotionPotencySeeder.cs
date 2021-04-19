using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class PotionPotencySeeder : IEntitySeed<PotionPotency>
    {
        public IEnumerable<PotionPotency> GetSeedEntities()
        {
            yield return new PotionPotency { Id = Guid.Parse("5e2f27d1-6b8b-41a0-8f58-095a4bb926d3"), Name = "Unclassified" };
            yield return new PotionPotency { Id = Guid.Parse("d48e6d86-0396-4d4e-89dd-3396203ae7ff"), Name = "Minor" };
            yield return new PotionPotency { Id = Guid.Parse("ceca3c25-9aec-4b3e-ba74-2e13dbe60a8c"), Name = "Lesser" };
            yield return new PotionPotency { Id = Guid.Parse("de779bc7-3125-409a-82bb-49e68820101a"), Name = "Moderate" };
            yield return new PotionPotency { Id = Guid.Parse("8f7a4620-e8d8-432c-a0ec-5323b3cc738d"), Name = "Greater" };
            yield return new PotionPotency { Id = Guid.Parse("4852d7fd-20c3-442e-99c2-44416cf925ba"), Name = "Major" };
            yield return new PotionPotency { Id = Guid.Parse("cf956f07-1342-4bab-ac64-d71f2832bb54"), Name = "True" };
        }
    }
}
