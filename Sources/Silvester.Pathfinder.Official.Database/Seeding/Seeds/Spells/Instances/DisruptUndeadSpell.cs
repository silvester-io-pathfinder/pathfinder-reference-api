using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DisruptUndeadSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Cantrip";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Necromancy";
        public override string SavingThrowStat => "Fortitude";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("db143e7b-8212-4350-a09f-09205811470e"),
                Name = "Disrupt Undead",
                Description = "You lance the target with energy. You deal 1d6 positive damage plus your spellcasting ability modifier. The target must attempt a basic Fortitude save.",
                Level = 1,
                Range = 30,
                Targets = "1 undead creature."
            };
        }
        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("7c7d9f59-2899-4af7-9596-cf6a7711da5a"),
                CriticalFailure = "The creature is also enfeebled 1 for 1 round."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("637c1c9a-e2f9-497d-85fc-9ca72fbba552"), Level = 1, Description = "The damage increases by 1d6." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Cantrip";
            yield return "Necromancy";
            yield return "Positive";
        }
    }
}
