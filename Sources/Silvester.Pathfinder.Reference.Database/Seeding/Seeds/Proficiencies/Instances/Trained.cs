using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Proficiencies.Instances
{
    public class Trained : Template
    {
        public static readonly Guid ID = Guid.Parse("130841fd-de3b-45e7-bb97-c4ded6ec71e8");

        public override Proficiency GetProficiency()
        {
            return new Proficiency
            {
                Id = ID,
                Bonus = 2,
                Name = "Trained"
            };
        }
    }
}
