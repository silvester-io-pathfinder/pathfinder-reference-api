using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HideousLaughter : Template
    {
        public static readonly Guid ID = Guid.Parse("3f5aac9a-03cd-4c4b-8504-d6d3597e95a8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hideous Laughter",
                Level = 2,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Sustianed.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ca66e456-57da-4b4c-8401-5e89ebb5fa85"), Type = TextBlockType.Text, Text = "The target is overtaken with uncontrollable laughter. It must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("12dbb027-58d4-4b3f-84aa-b1bd660434e9"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is plagued with uncontrollable laugher. It can't use reactions.",
                Failure = "The target is slowed 1 and can't use reactions.",
                CriticalFailure = "The target falls prone and can't use actions or reactions for 1 round.It then suffers the failure effects."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("bb5005d4-38f7-4878-adec-5d37aeb193dd"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("f1598aa8-78b9-4f1e-bcdf-4814920bb45c"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("12921649-ccd6-49d4-8c3e-450408f4cc42"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be7333ff-dfd6-46dd-a224-c71c7492b0fc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 343
            };
        }
    }
}
