using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class LanguageTypeSeeder : IEntitySeeder<LanguageType>
    {
        public IEnumerable<LanguageType> GetSeedEntities()
        {
            yield return new LanguageType { Id = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac"), Name = "Common" };
            yield return new LanguageType { Id = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Uncommon" };
            yield return new LanguageType { Id = Guid.Parse("9e4b5cea-7c60-4396-aa80-307379d155ab"), Name = "Secret" };
            yield return new LanguageType { Id = Guid.Parse("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0"), Name = "Regional" };
            yield return new LanguageType { Id = Guid.Parse("705b76de-5a42-4e7b-aaf2-16feb7b232d0"), Name = "Sign" };
        }
    }
}