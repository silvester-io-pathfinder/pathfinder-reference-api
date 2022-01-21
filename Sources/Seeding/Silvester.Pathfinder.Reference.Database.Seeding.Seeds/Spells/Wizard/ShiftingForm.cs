using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShiftingForm : Template
    {
        public static readonly Guid ID = Guid.Parse("8c889ff7-c2b6-4c13-84f3-ebe934d07176");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shifting Form",
                Level = 4,
                IsDismissable = true,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84122d03-7e6a-4bc1-bef7-7754aed15c0f"), Type = TextBlockType.Text, Text = "You gain one of the following abilities of your choice. You can Dismiss this spell." };
            yield return new TextBlock { Id = Guid.Parse("868cef53-da5a-4c06-afc0-8200ec8172c6"), Type = TextBlockType.Enumeration, Text = "You gain a 20-foot status bonus to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("a2c46a4a-94a7-43d1-ae98-28d123616365"), Type = TextBlockType.Enumeration, Text = "You gain a climb or swim Speed equal to half your Speed." };
            yield return new TextBlock { Id = Guid.Parse("915c86c6-17c5-4b9c-a3bc-60684727951f"), Type = TextBlockType.Enumeration, Text = "You gain darkvision." };
            yield return new TextBlock { Id = Guid.Parse("a1257232-a85f-4392-b71b-3ff60b77c492"), Type = TextBlockType.Enumeration, Text = "You gain a pair of claws. These are agile finesse unarmed attacks that deal 1d8 slashing damage." };
            yield return new TextBlock { Id = Guid.Parse("f014b191-fe50-411d-ba4d-5bcad4416be9"), Type = TextBlockType.Enumeration, Text = "You gain scent 60 feet (imprecise)." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("96eb54d0-a58f-44bf-8799-bc16a2ba2cca"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("3704a1d6-84f6-4548-86f4-3d54988a1f1e"), Traits.Instances.Morph.ID);
            builder.Add(Guid.Parse("b68c435d-fbe5-40d2-981f-157989ead8d9"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("6dcc3645-cc37-4317-8097-363c180806ee"), Traits.Instances.Wizard.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e12c633-7d53-4211-8fca-733cd3e153ff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
