using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FleshToStone : Template
    {
        public static readonly Guid ID = Guid.Parse("03533db6-d74d-43cc-84e0-ec5f1c0177b8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Flesh to Stone",
                Level = 6,
                Range = "120 feet.",
                Duration = "Varies.",
                Targets = "1 creature made of flesh.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f0e52ed1-3a6a-4c03-aa5b-691b1b1db4e8"), Type = TextBlockType.Text, Text = "You try to turn the target's flesh into stone. The target must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("775df469-be19-45a1-91c1-dfa8b0b1d576"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is slowed 1 for 1 round.",
                Failure = "The target is slowed 1 and must attempt a Fortitude save at the end of each of its turns; this ongoing save has the incapacitation trait. On a failed save, the slowed condition increases by 1 (or 2 on a critical failure). A successful save reduces the slowed condition by 1. When a creature is unable to act due to the slowed condition from flesh to stone, the creature is permanently non-magically petrified. The spell ends if the creature is petrified or the slowed condition is removed.",
                CriticalFailure = "As failure, but the target is initially slowed 2."
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("53fda390-9540-49cc-a7c5-50439c0370a1"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30c34533-abc3-4ff5-8a2d-10eac23b46db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 339
            };
        }
    }
}
