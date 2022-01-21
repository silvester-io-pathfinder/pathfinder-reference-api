using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DreadAura : Template
    {
        public static readonly Guid ID = Guid.Parse("c8d6fe54-f66e-4bc6-8d5c-9441e04ab7db");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dread Aura",
                Level = 4,
                Area = "30-foot-radius emanation.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad138776-3ae1-47fe-949c-ba130167bd0e"), Type = TextBlockType.Text, Text = "You emit an aura of terror. Foes in the area are frightened 1 and unable to reduce the condition." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("f68094fb-b03c-4849-9641-8aa194a7f6d3"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("89ad3c2c-ecb2-470e-8c36-2207c63ac407"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("43c425dc-7d61-4bbb-a7a7-156f19cf6088"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("e164dd6f-c527-48f4-bd0f-7c7c60cb1e78"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("73c09da6-cccd-4f22-9ca7-d32cb97e18a7"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("61a2ab75-793c-4bc0-979c-326f93842046"), Traits.Instances.Wizard.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("561188b4-ad68-46c1-bc13-77484e0524a9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 406
            };
        }
    }
}
