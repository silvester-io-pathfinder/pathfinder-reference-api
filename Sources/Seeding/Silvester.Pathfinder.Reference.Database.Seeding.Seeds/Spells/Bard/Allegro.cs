using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Allegro : Template
    {
        public static readonly Guid ID = Guid.Parse("8a7a6e25-7506-4477-87e5-3bb8477f2616");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Allegro",
                Level = 7,
                Range = "30 feet.",
                Duration = "1 round.",
                Targets = "1 ally.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a146f87-7db4-4e9b-b486-a5d02154f1ea"), Type = TextBlockType.Text, Text = "You perform rapidly, speeding up your ally. The ally becomes quickened and can use the additional action to Strike, Stride, or Step." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("cb77ee8d-90bb-4cc5-8b22-381d93ecee5b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7b80a48d-f754-4af2-98cc-2d3cfae2eb5d"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("91987025-dacd-425e-abf3-798df0f65c40"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("a1a4c933-7586-4098-b5b6-b5372b8cb99c"), Traits.Instances.Composition.ID);
            builder.Add(Guid.Parse("aeb5fac3-0d57-4c3b-9bf1-ac680b4b4471"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("4e279a79-f26a-42d4-8518-12f992b72981"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("ce4ad24c-3ac4-4922-897f-45a1fcf8efe1"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f20455d1-3462-42ef-9bb4-aa1d4b91665a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 386
            };
        }
    }
}
