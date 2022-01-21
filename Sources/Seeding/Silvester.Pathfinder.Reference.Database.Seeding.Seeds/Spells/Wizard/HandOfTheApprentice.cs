using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HandOfTheApprentice : Template
    {
        public static readonly Guid ID = Guid.Parse("a5d8f9d2-b600-4663-9354-8318e717c0f0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hand of the Apprentice",
                Level = 1,
                Range = "500 feet.",
                Targets = "1 creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c9facd51-cbe5-4bfd-88eb-0acbb2a12b45"), Type = TextBlockType.Text, Text = "You hurl a held melee weapon with which you are trained at the target, making a spell attack roll. On a success, you deal the weapon's damage as if you had hit with a melee Strike, but adding your spellcasting ability modifier to damage, rather than your Strength modifier. On a critical success, you deal double damage, and you add the weapon's critical specialization effect. Regardless of the outcome, the weapon flies back to you and returns to your hand." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d4703057-2477-46bc-9030-c77a52c45941"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("1e04e663-1c8c-44f0-8456-dfee8322a480"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("e236cd4b-fbdc-4e0a-8c7c-217aa00e5f69"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("656e811c-903e-4986-87da-59c91b876e6a"), Traits.Instances.Wizard.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("896bf7ab-98c9-4100-8b6a-6711dd569c3a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
