using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicSchools.Instances
{
    public class Enchantment : Template
    {
        public static readonly Guid ID = Guid.Parse("652580a1-b993-4326-9baa-460b5f6c9ba0");

        protected override MagicSchool GetMagicSchool()
        {
            return new MagicSchool
            {
                Id = ID,
                Name = "Enchantment",
                Abbreviation = "ENC",
                Description = "Enchantments affect the minds and emotions of other creatures—sometimes to influence and control them, and other times to bolster them to greater heights of courage. Enchantment spells almost always have the mental trait, and many have the emotion trait or the fear trait."
            };
        }
    }
}
