using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PhysicalBoost : Template
    {
        public static readonly Guid ID = Guid.Parse("681a87e9-9b6d-4188-b3b2-35e7f5dd69b5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Physical Boost",
                Level = 1,
                Range = "Touch.",
                Duration = "Until the end of the target's next turn.",
                Targets = "1 living creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b0bd2e8d-0ad8-4dc5-aaf1-00a7385314af"), Type = TextBlockType.Text, Text = "You temporarily improve the target's physique. The target gains a +2 status bonus to the next Acrobatics check, Athletics check, Fortitude save, or Reflex save it attempts." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("128f50fb-aa52-4124-b2c2-0bdb3ed97f6b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("a1d46f48-7879-40b9-8e8a-9c6261a6ea7c"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("79a5d393-d9de-48d0-aec0-da248b1be2a2"), Traits.Instances.Wizard.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6636d9f7-2e0e-419b-b879-571c66f64078"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
