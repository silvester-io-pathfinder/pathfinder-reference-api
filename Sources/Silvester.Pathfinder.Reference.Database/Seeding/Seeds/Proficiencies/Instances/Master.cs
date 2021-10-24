using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Proficiencies.Instances
{
    public class Master : Template
    {
        public static readonly Guid ID = Guid.Parse("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56");

        public override Proficiency GetProficiency()
        {
            return new Proficiency
            {
                Id = ID,
                Bonus = 6,
                Name = "Master"
            };
        }
    }
}
