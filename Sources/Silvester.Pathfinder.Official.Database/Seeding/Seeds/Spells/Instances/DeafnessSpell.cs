using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DeafnessSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Necromancy";
        public override string SavingThrowStat => "Fortitude";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("509c9a55-433c-4f99-8a7a-609d38f23ed1"),
                Name = "Deafness",
                Description = "The target loses hearing; it must attempt a Fortitude save. The target is then temporarily immune for 1 minute.",
                Level = 2,
                Range = 30,
                Targets = "1 creature.",
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect 
            {
                Id = Guid.Parse("fa67be43-2108-4e4d-ab58-18edad117031"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is deafened for 1 round.",
                Failure = "The target is deafened for 10 minutes.",
                CriticalFailure = "The target is deafened permanently."
            };
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
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Necromancy";
        }
    }
}
