using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class MagicEssenceSeeder : IEntitySeed<MagicEssence>
    {
        public IEnumerable<MagicEssence> GetSeedEntities()
        {
            yield return new MagicEssence { Id = Guid.Parse("c02c29d8-351b-4690-bfd6-85447ee129e1"), Name = "Matter", Description = "Also called body, material essence, or physical essence, matter is the fundamental building block that makes up all physical things in the universe. The arcane and primal traditions are especially attuned toward manipulating and shaping matter. Spells that are used to create or alter matter most often come from the conjuration, evocation, or transmutation schools." };
            yield return new MagicEssence { Id = Guid.Parse("3a378975-c527-4240-a39c-4b854bc00573"), Name = "Spirit", Description = "Also called soul, ethereal essence, or spiritual essence, spirit is an otherworldly building block that makes up a being’s immaterial and immortal self. The spirit travels through the Ethereal Plane and into the Great Beyond after the death of the physical body. The spirit is most easily affected by divine and occult spells. Spirit spells are usually of the divination or necromancy schools." };
            yield return new MagicEssence { Id = Guid.Parse("b5228b30-f243-4ad2-94f4-499eb98919ac"), Name = "Mind", Description = "Also called thought, mental, or astral essence, mind is what allows thinking creatures to have rational thoughts, ideas, plans, logic, and memories. Mind touches even nonsapient creatures like animals, though in a more limited capacity. Arcane and occult casters usually excel at mind spells. Spells that use mind essence are usually found in the divination, enchantment, and illusion schools." };
            yield return new MagicEssence { Id = Guid.Parse("044429ac-181c-46a8-b031-c163ae407509"), Name = "Life", Description = "Also called heart, faith, instinct, or vital essence, life represents the animating universal force within all things. Whereas matter provides the base materials for a body, life keeps it alive and well. This essence is responsible for unconscious responses and belief, such as ancestral instincts and divine guidance. The divine and primal traditions hold power over life. Life spells are usually necromancy." };
        }
    }
}
