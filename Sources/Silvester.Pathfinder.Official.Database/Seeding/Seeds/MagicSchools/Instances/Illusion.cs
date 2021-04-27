using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicSchools.Instances
{
    public class Illusion : AbstractMagicSchoolTemplate
    {
        public static readonly Guid ID = Guid.Parse("dd5fe60b-e821-4f80-86cb-ed5a9791d1e7");

        protected override MagicSchool GetMagicSchool()
        {
            return new MagicSchool
            {
                Id = ID,
                Name = "Illusion",
                Abbreviation = "ILL",
                Description = "Illusions create the semblance of something real, the eyes, ears, and other senses.Depending on how the illusion is perceived, it might have the auditory or traits, and some also have the mental trait."
            };
        }
    }
}
