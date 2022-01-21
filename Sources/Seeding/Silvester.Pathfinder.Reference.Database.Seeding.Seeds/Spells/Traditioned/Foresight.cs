using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Foresight : Template
    {
        public static readonly Guid ID = Guid.Parse("e6ec03cd-0356-4e8f-9cc6-661e477e5dea");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Foresight",
                Level = 9,
                Range = "Touch.",
                Duration = "1 hour.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ece0054d-ed1f-4e65-8984-e425f7e7446d"), Type = TextBlockType.Text, Text = "You gain a sixth sense that warns you of danger that might befall the target of the spell. If you choose a creature other than yourself as the target, you create a psychic link through which you can inform the target of danger. This link is a mental effect. Due to the amount of information this spell requires you to process, you can't have more than one foresight spell in effect at a time. Casting foresight again ends the previous foresight. While foresight is in effect, the target gains a +2 status bonus to initiative rolls and isn't flat-footed against undetected creatures or when flanked. In addition, you gain the following reaction." };
        }

        protected override IEnumerable<InlineAction> GetInlineActions()
        {
            yield return new InlineAction
            {
                Id = Guid.Parse("83d81777-aa02-4e02-8901-dc3d8217d152"),
                Name = "Foresight",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Trigger = "The target of foresight defends against a hostile creature or other danger.",
                Effect = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("a3089104-350f-42f5-a70a-7caff03af46e"), Type = TextBlockType.Text, Text = "If the hostile creature or danger forces the target to roll dice (a saving throw, for example), the target rolls twice and uses the higher result, and this spell gains the fortune trait. But if the hostile creature or danger is rolling against the target (an attack roll or skill check, for example), that hostile creature or danger rolls twice and uses the lower result, and this spell gains the misfortune trait."},
                }
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
            builder.Add(Guid.Parse("ca777c22-64bc-4c8f-93a9-9c78fcd39ab9"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("d9b9b59c-9a18-4437-b989-8d28513f32bf"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("9a3d5a67-09b6-4595-8225-47b1790e3b31"), Traits.Instances.Prediction.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8a1696d-2a9f-410e-b73a-5f38079dce19"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 340
            };
        }
    }
}
