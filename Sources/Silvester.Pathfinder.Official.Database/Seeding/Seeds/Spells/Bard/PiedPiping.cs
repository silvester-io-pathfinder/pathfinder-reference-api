using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PiedPiping : Template
    {
        public static readonly Guid ID = Guid.Parse("64ec1a63-ef3c-4461-bab0-7a3ea3f6a598");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Pied Piping",
                Level = 10,
                Area = "5-foot emanation.",
                Duration = "1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30d1976d-17a2-48a9-a820-5af8b70f906e"), Type = TextBlockType.Text, Text = "Your performance enraptures those who hear it, compelling them to follow you about in admiration. Each creature within the emanation must attempt a Will save when you Cast the Spell or the first time they enter the area, after which they become temporarily immune for 1 day. Once per turn, you can spend a single action, which has the concentrate trait, to increase the emanation’s radius by 5 feet. You can Dismiss the spell." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("fa6ffabd-4c44-4885-a596-641a0fcbbd2c"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is fascinated with you.",
                Failure = "The creature uses all its actions to move toward you and compliment your performance. This effect ends if a hostile action is used against the affected creature.",
                CriticalFailure = "The target gains the minion trait and is controlled by you. This effect ends if a hostile action is used against the affected creature, or if you direct the creature to use any action that causes it harm."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Composition.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Sonic.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("161a35c1-2249-40aa-9f86-ffe6f75c8cd4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 228
            };
        }
    }
}
