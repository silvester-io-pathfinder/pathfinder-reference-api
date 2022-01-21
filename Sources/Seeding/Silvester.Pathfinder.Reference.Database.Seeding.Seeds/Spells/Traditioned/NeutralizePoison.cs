using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class NeutralizePoison : Template
    {
        public static readonly Guid ID = Guid.Parse("8813eb2e-1128-4dfb-b926-5b0ee4b4f910");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Neutralize Poison",
                Level = 3,
                Range = "Touch.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("73442b3d-3937-494f-8777-d4fdf8af4d27"), Type = TextBlockType.Text, Text = "You pour healing magic through the target in an attempt to cure one poison afflicting it. Attempt a counteract check against the poison." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("3eea86bf-a3ff-434e-b0df-19532ec1667c"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("e39047e8-d1d4-49d8-9ca4-28563a1d15c6"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("facf9a07-05d7-4e8a-a18a-1afc74561d14"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 354
            };
        }
    }
}
