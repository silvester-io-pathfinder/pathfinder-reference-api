using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicSchools.Instances
{
    public class Necromancy : Template
    {
        public static readonly Guid ID = Guid.Parse("fe316215-5436-422b-bd3f-c499d05b5b99");

        protected override MagicSchool GetMagicSchool()
        {
            return new MagicSchool
            {
                Id = ID,
                Name = "Necromancy",
                Abbreviation = "NEC",
                Description = "Necromancy spells harness the power of life and death. They can sap life essence or sustain creatures with life-saving healing. Necromancy spells often have the curse, death, healing, negative, or positive traits."
            };
        }
    }
}
