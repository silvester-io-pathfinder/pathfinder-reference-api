using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CrushingDespairSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Enchantment";
        public override string SavingThrowStat => "Will";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("2665ca32-131c-43cd-b30b-c763eb024a08"),
                Name = "Crushing Despair",
                Description = "You inflict despair on creatures in the area. The effects for each creature are determined by its Will save.",
                Level = 5,
                Area ="30-foot cone.",
                Duration = "1 or more rounds."
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("48a3785a-a84b-4290-9316-b41d51744c0a"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "For 1 round, the creature can’t use reactions and must attempt another save at the start of its turn; on a failure, it is slowed 1 for that turn as it sobs uncontrollably.",
                Failure = "As success, but the duration is 1 minute.",
                CriticalFailure = "As failure, and the creature is automatically slowed 1 for 1 minute."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("cecf2b46-be78-406a-ab01-b1bff4d3917a"), Level = 7, Description = "The area increases to a 60-foot cone." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Emotion";
            yield return "Enchantment";
            yield return "Mental";
        }
    }
}
