using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EvilEye : Template
    {
        public static readonly Guid ID = Guid.Parse("5357885a-fcae-43c9-bfa0-61e6e41a2e6e");

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
            yield return new TextBlock { Id = Guid.Parse("f2c7628d-2b2d-4250-aee8-25d6ead5a5f6"), Type = TextBlockType.Text, Text = "Your fix your eye on the target, imposing a malevolent hex. The target becomes frightened based on the results of its Will save. This condition value can’t be reduced below 1 while the spell is active and you can see the target. Regardless of the outcome, the target is then temporarily immune for 1 minute." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("98d96fc4-6fcf-47fb-bfa0-6ac47b882188"),
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
                Id = Guid.Parse("98b6b3ff-8aca-4bd8-8d25-552a446972a5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 238
            };
        }
    }
}
