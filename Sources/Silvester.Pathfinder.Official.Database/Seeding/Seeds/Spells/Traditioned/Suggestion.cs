using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Suggestion : Template
    {
        public static readonly Guid ID = Guid.Parse("a5df0891-bfa9-4cf4-bf91-7172887800a0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Suggestion",
                Level = 4,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a5df0891-bfa9-4cf4-bf91-7172887800a0"), Type = TextBlockType.Text, Text = "Your honeyed words are difficult for creatures to resist. You suggest a course of action to the target, which must be phrased in such a way as to seem like a logical course of action to the target and can’t be self-destructive or obviously against the target’s self-interest. The target must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a5df0891-bfa9-4cf4-bf91-7172887800a0"), 
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a5df0891-bfa9-4cf4-bf91-7172887800a0"), Type = TextBlockType.Text, Text = "You can target up to 10 creatures." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("a5df0891-bfa9-4cf4-bf91-7172887800a0"),
                CriticalSuccess = "The target is unaffected and knows you tried to control it.",
                Success = "The target is unaffected and thinks you were talking to them normally, not casting a spell on them.",
                Failure = "The target immediately follows your suggestion. The spell has a duration of 1 minute, or until the target has completed a finite suggestion or the suggestion becomes self-destructive or has other obvious negative effects.",
                CriticalFailure = "As failure, but the base duration is 1 hour."
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
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5df0891-bfa9-4cf4-bf91-7172887800a0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 374
            };
        }
    }
}
