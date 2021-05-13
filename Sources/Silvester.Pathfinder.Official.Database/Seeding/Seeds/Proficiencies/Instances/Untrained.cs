using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Proficiencies.Instances
{
    public class Untrained : Template
    {
        public static readonly Guid ID = Guid.Parse("b5a58093-b365-4b88-8f0e-05317473522b");

        public override Proficiency GetProficiency()
        {
            return new Proficiency
            {
                Id = ID,
                Bonus = 0,
                Name = "Untrained"
            };
        }
    }
}
