using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class ProficiencySeeder : IEntitySeeder<Proficiency>
    {
        public IEnumerable<Proficiency> GetSeedEntities()
        {
            yield return new Proficiency { Id = Guid.Parse("b5a58093-b365-4b88-8f0e-05317473522b"), Bonus = 0, Name = "Untrained" };
            yield return new Proficiency { Id = Guid.Parse("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), Bonus = 2, Name = "Trained" };
            yield return new Proficiency { Id = Guid.Parse("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), Bonus = 4, Name = "Expert" };
            yield return new Proficiency { Id = Guid.Parse("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), Bonus = 6, Name = "Master" };
            yield return new Proficiency { Id = Guid.Parse("5184371d-aad0-4d76-b43c-b03d5e930ddb"), Bonus = 8, Name = "Legendary" };
        }
    }
}
