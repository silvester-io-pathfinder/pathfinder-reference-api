using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicEssences.Instances
{
    public class Matter : AbstractMagicEssenceTemplate
    {
        public static readonly Guid ID = Guid.Parse("c02c29d8-351b-4690-bfd6-85447ee129e1");

        protected override MagicEssence GetMagicEssence()
        {
            return new MagicEssence
            {
                Id = ID,
                Name = "Matter",
                Description = "Also called body, material essence, or physical essence, matter is the fundamental building block that makes up all physical things in the universe. The arcane and primal traditions are especially attuned toward manipulating and shaping matter. Spells that are used to create or alter matter most often come from the conjuration, evocation, or transmutation schools."
            };
        }
    }
}
