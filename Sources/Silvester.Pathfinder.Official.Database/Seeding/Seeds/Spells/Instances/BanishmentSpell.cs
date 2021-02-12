using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BanishmentSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Abjuration";
        public override string SavingThrowStat => "Will";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("3a8c5edf-e86c-431a-a25a-bb90d590eb35"),
                Name = "Banishment",
                Description = "You send the target back to its home plane. The target must attempt a Will save. You can spend an extra action while Casting this Spell and add a material component to give the creature a –2 circumstance penalty to its save. The component must be a specially gathered object that is anathema to the creature, and not from a material component pouch. This spell fails if you aren’t on your home plane when you cast it.",
                Level = 5,
                Range = 30,
                Targets = "1 creature that isn't on its home plane."
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("dd05b759-b382-42f9-bfef-e8600b2b28f9"),
                CriticalSuccess = "The target resists being banished and you are stunned 1.",
                Success = "The target resists being banished.",
                Failure = "The target is banished.",
                CriticalFailure = "The target is banished and can’t return by any means to the plane it’s banished from for 1 week."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("62d6f3f0-5ae7-4ceb-b943-d716a9d05586"), Level = 9, Description = "You can target up to 10 creatures. The extra material component affects targets to which it is anathema." };
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
            yield return "Abjuration";
            yield return "Incapacitation";
        }
    }
}
