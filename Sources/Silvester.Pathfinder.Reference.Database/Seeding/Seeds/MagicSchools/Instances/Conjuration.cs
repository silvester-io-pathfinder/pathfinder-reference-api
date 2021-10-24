using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MagicSchools.Instances
{
    public class Conjuration : Template
    {
        public static readonly Guid ID = Guid.Parse("1c401dd4-21d6-477d-9ca1-1a6a9d1a8a0d");

        protected override MagicSchool GetMagicSchool()
        {
            return new MagicSchool
            {
                Id = ID,
                Name = "Conjuration",
                Abbreviation = "CON",
                Description = "Conjuration spells transport creatures via teleportation, create an object, bring a creature or object from somewhere else (typically from plane) to follow your commands Conjuration spells often have the teleportation trait, and creatures summoned by conjuration spells have the summoned trait."
            };
        }
    }
}
