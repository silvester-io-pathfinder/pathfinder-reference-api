using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DeathKnellSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Necromancy";
        public override string SavingThrowStat => "Will";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("236cd0a3-a07b-4c9f-ba11-e3c113d91634"),
                Name = "Death Knell",
                Description = "You snuff the life out of a creature on the brink of death. The target must attempt a Will save. If this kills it, you gain 10 temporary HP and a +1 status bonus to attack and damage rolls for 10 minutes.",
                Level = 2,
                Range = 0,
                Targets = "1 living creature that has 0 HP.",
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect 
            {
                Id = Guid.Parse("1d97f155-61d4-4e3e-b56a-5db39776f857"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target’s dying value increases by 1.",
                Failure = "The target dies."
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Death";
            yield return "Necromancy";
        }
    }
}
