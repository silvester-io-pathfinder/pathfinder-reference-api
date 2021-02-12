using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DimensionalAnchorSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Abjuration";
        public override string SavingThrowStat => "Will";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("c1546cbd-ec60-459f-b7f5-e29d51beb5f2"),
                Name = "Dimensional Anchor",
                Description = "You interfere with the target’s ability to teleport and travel between dimensions. Dimensional anchor attempts to counteract any teleportation effect, or any effect that would move the target to a different plane. The duration is determined by the target’s Will save.",
                Level = 4,
                Range = 30,
                Targets = "1 creature",
                Duration = "Varies."
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect 
            {
                Id = Guid.Parse("7a397e05-ef94-4531-a4d8-24e4596d37c7"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The effect’s duration is 1 minute.",
                Failure = "The effect’s duration is 10 minutes.", 
                CriticalFailure = "The effect’s duration is 1 hour."
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
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Abjuration";
        }
    }
}
