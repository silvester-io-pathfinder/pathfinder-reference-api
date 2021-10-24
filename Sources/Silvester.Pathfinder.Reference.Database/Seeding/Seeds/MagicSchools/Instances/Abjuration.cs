using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MagicSchools.Instances
{
    public class Abjuration : Template
    {
        public static readonly Guid ID = Guid.Parse("76c4e166-abdb-471f-8fde-4c08a765ce2b");

        protected override MagicSchool GetMagicSchool()
        {
            return new MagicSchool
            {
                Id = ID,
                Name = "Abjuration",
                Abbreviation = "ABJ",
                Description = "Abjurations protect and ward. They create barriers that keep out attacks effects, or even certain types of creatures. They also create effects that harm trespassers or banish interlopers."
            };
        }
    }
}
