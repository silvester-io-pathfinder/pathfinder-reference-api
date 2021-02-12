using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BlindnessSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Necromancy";
        public override string SavingThrowStat => "Fortitude";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("3a320d74-73e9-40ab-a972-eb6b571f21fd"),
                Name = "Blindness",
                Description = "You blind the target. The effect is determined by the target’s Fortitude save. The target then becomes temporarily immune for 1 minute.",
                Level = 3,
                Range = 30,
                Targets = "1 creature."
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect 
            { 
                Id = Guid.Parse("2130dd1b-4239-4b15-9565-f962a6bf3cee"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is blinded until its next turn begins.",
                Failure = "The target is blinded for 1 minute.",
                CriticalFailure = "The target is blinded permanently."
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
            yield return "Incapacitation";
            yield return "Necromancy";
        }
    }
}
