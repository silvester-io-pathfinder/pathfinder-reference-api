using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicSchools.Instances
{
    public class Evocation : AbstractMagicSchoolTemplate
    {
        public static readonly Guid ID = Guid.Parse("438b96b3-ea22-4131-b938-ce7073c933b4");

        protected override MagicSchool GetMagicSchool()
        {
            return new MagicSchool
            {
                Id = ID,
                Name = "Evocation",
                Abbreviation = "EVO",
                Description = "Evocations capture magical energy and then shape it to harm your foes or protect your allies. Evocation spells often have a trait that comes from the type of damage they deal, such as acid, cold, fire, force, or sonic."
            };
        }
    }
}
