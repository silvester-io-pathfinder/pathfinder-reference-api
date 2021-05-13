using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicEssences.Instances
{
    public class Mind : Template
    {
        public static readonly Guid ID = Guid.Parse("b5228b30-f243-4ad2-94f4-499eb98919ac");

        protected override MagicEssence GetMagicEssence()
        {
            return new MagicEssence
            {
                Id = ID,
                Name = "Mind",
                Description = "Also called thought, mental, or astral essence, mind is what allows thinking creatures to have rational thoughts, ideas, plans, logic, and memories. Mind touches even nonsapient creatures like animals, though in a more limited capacity. Arcane and occult casters usually excel at mind spells. Spells that use mind essence are usually found in the divination, enchantment, and illusion schools."
            };
        }
    }
}
