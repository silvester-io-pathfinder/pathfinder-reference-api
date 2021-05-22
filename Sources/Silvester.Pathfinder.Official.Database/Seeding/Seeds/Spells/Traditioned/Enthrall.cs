using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Enthrall : Template
    {
        public static readonly Guid ID = Guid.Parse("bb133e97-c0be-4c85-bce1-efd4f4cee979");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Enthrall",
                Level = 3,
                Range = "120 feet.",
                IsDismissable = true,
                Duration = "Sustained.",
                Targets = "All creatures in range.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("87c7cd27-5fd2-40c1-b985-d192409bc2b5"), Type = TextBlockType.Text, Text = "Your words fascinate your targets. You speak or sing without interruption throughout the casting and duration. Targets who notice your speech or song might give their undivided attention; each target must attempt a Will save. The GM might grant a circumstance bonus (to a maximum of +4) if the target is of an opposing religion, ancestry, or political leaning, or is otherwise unlikely to agree with what you’re saying." };
            yield return new TextBlock { Id = Guid.Parse("ea317430-421c-4cb3-9ff1-9f438186110a"), Type = TextBlockType.Text, Text = "Each creature that comes within range has to attempt a save when you Sustain the Spell. If you’re speaking, enthrall gains the linguistic trait." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("4d977be1-3d58-4391-8185-77a3037f3b1d"),
                CriticalSuccess = "The target is unaffected and notices that you tried to use magic.",
                Success = "The target needn’t pay attention but doesn’t notice you tried to use magic(it might notice others are enthralled).",
                Failure = "The target is fascinated with you. It can attempt another Will save if it witnesses actions or speech with which it disagrees. If it succeeds, it’s no longer fascinated and is temporarily immune for 1 hour. If the target is subject to a hostile act, or if another creature succeeds at a Diplomacy or Intimidation check against it, the fascination ends immediately.",
                CriticalFailure = "As failure, but the target can’t attempt a save to end the fascination if it disagrees with you."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2278e6a3-79d8-4871-a5a2-55bdaf7292e8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 336
            };
        }
    }
}
