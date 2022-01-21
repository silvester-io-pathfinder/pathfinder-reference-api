using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Disjunction : Template
    {
        public static readonly Guid ID = Guid.Parse("05375af9-4bc5-4eab-8731-2fb74c2062d9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Disjunction",
                Level = 9,
                Range = "120 feet.",
                Targets = "1 magical item.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5e2bbdd-edd9-4905-8c2c-1f8f08305001"), Type = Utilities.Text.TextBlockType.Text, Text = "Crackling energy disjoins the target. You attempt to counteract it (page 458). If you succeed, it's deactivated for 1 week. On a critical success, it's destroyed. If it's an artifact or similar item, you automatically fail." };
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
            builder.Add(Guid.Parse("c8944c86-f2c6-4d0c-9e15-08967aa5546d"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("2f70321d-60b9-4bb2-b419-41cf6e96e91c"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7aef442b-cf31-422a-ac6d-196eef3acaa1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 330
            };
        }
    }
}
