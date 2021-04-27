using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Proficiencies.Instances
{
    public class Expert : AbstractProficiencyTemplate
    {
        public static readonly Guid ID = Guid.Parse("e75eb2e8-f901-4d74-8497-05b7f2e689a9");

        public override Proficiency GetProficiency()
        {
            return new Proficiency
            {
                Id = ID,
                Bonus = 4,
                Name = "Expert"
            };
        }
    }
}
