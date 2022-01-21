using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LifeSiphon : Template
    {
        public static readonly Guid ID = Guid.Parse("52cde738-bac5-48e6-a245-3f51ff948fa4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Life Siphon",
                Level = 4,
                Trigger = "You expend one of your wizard spell slots to cast a wizard spell of the necromancy school.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("74d506fe-cae9-4d97-9f45-886a3206cd00"), Type = TextBlockType.Text, Text = "You use some of the spell's magic to heal yourself, regaining 1d8 Hit Points per level of the spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("74eb8cd2-a645-46d1-a905-1f14bc8dfdf2"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("9b001044-4fbd-4a0d-94ed-31e759f2ec0a"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("2d88a7cb-accf-42a8-8acc-102fc191b58e"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("18396c2d-8ee7-4355-b3f5-646490e3ec4f"), Traits.Instances.Wizard.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f0fa532-07b8-4b42-92e6-56ae0a6e4739"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
