using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class UncontrollableDance : Template
    {
        public static readonly Guid ID = Guid.Parse("3657f192-4ce8-4d93-841e-1bacba2f6c36");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Uncontrollable Dance",
                Level = 8,
                Range = "Touch.",
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
            yield return new TextBlock { Id = Guid.Parse("3657f192-4ce8-4d93-841e-1bacba2f6c36"), Type = TextBlockType.Text, Text = "The target is overcome with an all-consuming urge to dance. For the duration of the spell, the target is flat-footed and can’t use reactions. While affected, the creature can’t use actions with the move trait except to dance, using the Stride action to move up to half its Speed." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("3657f192-4ce8-4d93-841e-1bacba2f6c36"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The spell’s duration is 3 rounds, and the target must spend at least 1 action each turn dancing.",
                Failure = "The spell’s duration is 1 minute, and the target must spend at least 2 actions each turn dancing.",
                CriticalFailure = "The spell’s duration is 1 minute, and the target must spend all its actions each turn dancing."
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
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3657f192-4ce8-4d93-841e-1bacba2f6c36"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 379
            };
        }
    }
}
