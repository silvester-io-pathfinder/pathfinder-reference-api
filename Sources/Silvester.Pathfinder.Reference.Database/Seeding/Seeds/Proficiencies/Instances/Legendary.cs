using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Proficiencies.Instances
{
    public class Legendary : Template
    {
        public static readonly Guid ID = Guid.Parse("5184371d-aad0-4d76-b43c-b03d5e930ddb");

        public override Proficiency GetProficiency()
        {
            return new Proficiency
            {
                Id = ID,
                Bonus = 8,
                Name = "Legendary"
            };
        }
    }
}
