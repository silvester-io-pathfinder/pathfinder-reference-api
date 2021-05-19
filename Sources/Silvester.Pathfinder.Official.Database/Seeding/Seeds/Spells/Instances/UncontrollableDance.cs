using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class UncontrollableDance : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The target is overcome with an all-consuming urge to dance. For the duration of the spell, the target is flat-footed and can’t use reactions. While affected, the creature can’t use actions with the move trait except to dance, using the Stride action to move up to half its Speed." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse(""),
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 379
            };
        }
    }
}
