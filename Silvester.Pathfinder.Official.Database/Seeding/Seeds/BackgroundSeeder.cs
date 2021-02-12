using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class BackgroundSeeder : IEntitySeeder<Background>
    {
        public IEnumerable<Background> GetSeedEntities()
        {
            yield return new Background { Id = Guid.Parse("89f46a25-7382-4f61-8492-c314019008e9"), SourceId = Guid.Parse("4e85ec44-4a72-4bea-a3e5-5e6d88882d75"), Name = "Acolyte", Description = "" };
        }
    }
}
