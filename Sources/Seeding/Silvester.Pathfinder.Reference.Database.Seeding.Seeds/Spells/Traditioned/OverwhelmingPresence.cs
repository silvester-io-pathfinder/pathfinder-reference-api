using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class OverwhelmingPresence : Template
    {
        public static readonly Guid ID = Guid.Parse("1f6026bc-7381-477d-a61c-70769fbf8fab");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Overwhelming Presence",
                Level = 9,
                Area = "40-foot burst.",
                Duration = "Until full tribute is paid.",
                Targets = "Any number of creatures.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f4291ff-7d81-4784-920a-7df03917b47a"), Type = TextBlockType.Text, Text = "You surround yourself with supernatural splendor, appearing to be a god or similarly majestic being. You choose the aspects of your new majestic appearance. This causes the targets to pay tribute to you by bowing or using some other action in keeping with your appearance. The number of times a target must do this depends on the result of their Will save." };
            yield return new TextBlock { Id = Guid.Parse("d3448213-6a58-4bb5-9b8b-769e3de92933"), Type = TextBlockType.Text, Text = "Paying tribute is a manipulate action or move action, as chosen by the creature paying tribute. A creature under this effect must pay tribute to you at least once on each of its turns if possible. While affected by this spell, a creature is fascinated by you and can't use hostile actions against you. The target is then temporarily immune for 1 minute." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("78383ab1-1c94-4bf0-95ce-3137de0f5c25"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target must pay tribute twice.",
                Failure = "The target must pay tribute six times.",
                CriticalFailure = "As failure, and the target must spend all its actions paying tribute if possible."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("8126aca4-44c2-4331-90a2-95bc5ab7fc14"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("811d1369-838b-4589-b8a2-26050a05d0cb"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("1d6492c3-ff20-4b10-8af2-389b5dd5d46b"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("88c3fceb-6b77-4736-a6aa-9fe16faaf252"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("dc4f5b91-1b5f-4d6b-a3f9-c6d119766795"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c063c827-7c6f-40b7-b476-0d8a130722b8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 356
            };
        }
    }
}
