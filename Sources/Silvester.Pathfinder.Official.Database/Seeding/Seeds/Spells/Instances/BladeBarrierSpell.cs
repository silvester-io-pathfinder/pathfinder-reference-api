using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BladeBarrierSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Three Actions";
        public override string MagicSchool => "Evocation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("54176cd6-c3a3-43fd-8d47-9283811b03bb"),
                Name = "Blade Barrier",
                Description = "Blades of force form a churning wall. The wall is a straight line 20 feet high, 120 feet long, and 2 inches thick, and it provides cover. The wall deals 7d8 force damage to each creature that’s in the wall’s space when it is created, that attempts to pass through the wall, or that ends its turn inside the wall. A basic Reflex save reduces the damage. A creature that succeeds at this save when the wall is created is pushed to the nearest space on the side of its choice. Creatures trying to move through the wall fail to do so if they critically fail the save, ending their movement adjacent to the wall.",
                Level = 6,
                Range = 120,
                Duration = "1 minute."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("3a1aa8fe-d985-4af4-a664-e7ceed761d9d"), Level = 1, Description = "The damage increases by 1d8." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Material";
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Evocation";
            yield return "Force";
        }
    }
}
