using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SynapticPulse : Template
    {
        public static readonly Guid ID = Guid.Parse("ff101b9d-f27f-437b-8eac-c5b18850d47c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Synaptic Pulse",
                Level = 5,
                Range = "30 feet.",
                Area = "30-foot emanation.",
                Duration = "1 round.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ff101b9d-f27f-437b-8eac-c5b18850d47c"), Type = TextBlockType.Text, Text = "You emit a pulsating mental blast that penetrates the minds of all enemies in the area. Each creature in the area must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("ff101b9d-f27f-437b-8eac-c5b18850d47c"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is stunned 1.",
                Failure = "The creature is stunned 2.",
                CriticalFailure = "The creature is stunned for 1 round."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff101b9d-f27f-437b-8eac-c5b18850d47c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 376
            };
        }
    }
}
