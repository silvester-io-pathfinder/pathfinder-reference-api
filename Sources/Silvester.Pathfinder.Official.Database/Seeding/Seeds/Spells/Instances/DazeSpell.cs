using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DazeSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Cantrip";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Enchantment";
        public override string SavingThrowStat => "Will";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("2d8be059-3a79-4d4d-a7e8-31dee66680cc"),
                Name = "Daze",
                Description = "You cloud the target’s mind and daze it with a mental jolt. The jolt deals mental damage equal to your spellcasting ability modifier; the target must attempt a basic Will save. If the target critically fails the save, it is also stunned 1.",
                Level = 1,
                Range = 50,
                Targets = "1 creature.",
                Duration = "1 round."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("aa381ca0-7a43-4e1b-9d5d-2ad73be5255d"), Level = 2, Description = "The damage increases by 1d6." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Divine";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Cantrip";
            yield return "Enchantment";
            yield return "Mental";
            yield return "Nonlethal";
        }
    }
}
