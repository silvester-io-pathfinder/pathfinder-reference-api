using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RoaringApplause : Template
    {
        public static readonly Guid ID = Guid.Parse("72e169e8-b373-4650-81d7-fdb610325bb1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Roaring Applause",
                Level = 3,
                Range = "60 feet.",
                Duration = "Sustained.",
                Targets = "1 creature.",
                IsDismissable = true,
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("da7eaa32-ee2a-4f1b-8d2d-0891712d627f"), Type = TextBlockType.Text, Text = "Your flamboyant flourish invokes such powerful feelings in your audience that you incite cheers and applause. Targets of this spell must be able to see, hear, or otherwise understand you. The targets must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c1eebf34-8b77-4914-a898-e722cf8e1d89"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("5d834184-3bca-44de-a530-93e83c7eaa62"), Type = TextBlockType.Text, Text = "You can target up to 10 creatures." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("97849982-6753-4753-83a6-53884dd705e4"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The target becomes mildly distracted by your display and applauds while it isn't fully occupied. It can't use reactions.",
                Failure = "The target applauds you so vigorously that it can't use reactions and is slowed 1. The applause is so involved that it has the manipulate trait. This triggers reactions based on the manipulate trait at the start of the target's turn.",
                CriticalFailure = "As failure, plus the target is so distracted by its vigorous applauding of you that it's fascinated with you."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e3c381d4-24e3-486d-9c80-1ea3a515500f"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("14057efd-c895-4b3e-8286-c9ca9cbb96d2"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("b33a3fd1-e0a9-4a61-8aa5-527126e1f3ba"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d11004b5-59d6-43a6-8fa5-1eddc95cb90e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 126
            };
        }
    }
}
