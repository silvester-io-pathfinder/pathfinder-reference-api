using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class EvilEye : Template
    {
        public static readonly Guid ID = Guid.Parse("29510220-4fc1-46df-a631-c7272bc61fd2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Evil Eye",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("29510220-4fc1-46df-a631-c7272bc61fd2"), Type = TextBlockType.Text, Text = "Your fix your eye on the target, imposing a malevolent hex. The target becomes frightened based on the results of its Will save. This condition value can’t be reduced below 1 while the spell is active and you can see the target. Regardless of the outcome, the target is then temporarily immune for 1 minute." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("29510220-4fc1-46df-a631-c7272bc61fd2"),
                Success = "The target is unaffected.",
                Failure = "The target is frightened 1.",
                CriticalFailure = "Critical Failure The target is frightened 2."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Curse.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29510220-4fc1-46df-a631-c7272bc61fd2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 238
            };
        }
    }
}
