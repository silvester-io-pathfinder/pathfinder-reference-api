using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MagicSchools.Instances
{
    public class Transmutation : Template
    {
        public static readonly Guid ID = Guid.Parse("ab0fac81-a9ed-410e-9886-99923111080a");

        protected override MagicSchool GetMagicSchool()
        {
            return new MagicSchool
            {
                Id = ID,
                Name = "Transmutation",
                Abbreviation = "TRA",
                Description = "Transmutation spells make alterations to or transform the physical form of a creature or object.The morph and polymorph traits appear primarily in transmutation spells."
            };
        }
    }
}
