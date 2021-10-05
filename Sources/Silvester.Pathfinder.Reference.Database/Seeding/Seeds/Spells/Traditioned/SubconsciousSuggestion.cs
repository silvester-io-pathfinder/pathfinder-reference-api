using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SubconsciousSuggestion : Template
    {
        public static readonly Guid ID = Guid.Parse("fd5cb944-c8a1-45b5-88b3-169c48550720");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Subconscious Suggestion",
                Level = 5,
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
            yield return new TextBlock { Id = Guid.Parse("cce13644-36ce-4b3a-951e-f4f16184fcd2"), Type = TextBlockType.Text, Text = "You implant a subconscious suggestion deep within the target’s mind for them to follow when a trigger you specify occurs (as described on page 305). You suggest a course of action to the target. Your directive must be phrased in such a way as to seem like a logical course of action to the target, and it can’t be selfdestructive or obviously against the target’s self-interest. The target must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3a5da0e8-c036-40c6-83dd-b7ea3ad69973"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("76ee5270-6823-44dd-90bd-9c1df8969c3c"), Type = TextBlockType.Text, Text = "You can target up to 10 creatures." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("71b9e690-1ce6-40f2-aa77-5ad68fb80e9d"),
                CriticalSuccess = "The target is unaffected and knows you tried to control it.",
                Success = "The target is unaffected and thinks you were talking to them normally, not casting a spell on them.",
                Failure = "The suggestion remains in the target’s subconscious until the next time you prepare. If the trigger occurs before then, the target immediately follows your suggestion. The effect has a duration of 1 minute, or until the target has completed a finite suggestion or the suggestion becomes self-destructive or has other obvious negative effects.",
                CriticalFailure = "As failure, but the duration is 1 hour."
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
                Id = Guid.Parse("11edb50c-2cc5-4309-a4b6-02232df4b681"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 374
            };
        }
    }
}
