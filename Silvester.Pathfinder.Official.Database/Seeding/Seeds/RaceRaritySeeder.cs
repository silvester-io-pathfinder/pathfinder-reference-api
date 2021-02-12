using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class RaceRaritySeeder : IEntitySeeder<RaceRarity>
    {
        public IEnumerable<RaceRarity> GetSeedEntities()
        {
            yield return new RaceRarity { Id = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), Name = "Common" };
            yield return new RaceRarity { Id = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), Name = "Uncommon" };
            yield return new RaceRarity { Id = Guid.Parse("863d10bd-583b-41e9-ae52-2d94cf0a2bff"), Name = "Rare" };
        }
    }
}
