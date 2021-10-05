using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RayOfEnfeeblement : Template
    {
        public static readonly Guid ID = Guid.Parse("f0d15a0d-0fe1-4bfc-a63e-1f4937d34871");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ray of Enfeeblement",
                Level = 1,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06db64b1-3aa9-4b9a-9c28-ab8b19869359"), Type = TextBlockType.Text, Text = "A ray that saps a foe’s strength flashes from your hand. Attempt a ranged spell attack against the target. If you succeed, that creature attempts a Fortitude save to determine the spell’s effect. If your attack roll is a critical success, use the outcome for one degree of success worse than the result of its save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("d6d65b6d-25c7-4dcd-8a1c-75b405293c66"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target becomes enfeebled 1.",
                Failure = "The target becomes enfeebled 2.",
                CriticalFailure = "The target becomes enfeebled 3."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d1e5d10-1543-44eb-86b8-c295315b2441"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 362
            };
        }
    }
}
