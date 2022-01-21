using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class KiRush : Template
    {
        public static readonly Guid ID = Guid.Parse("d090e3ba-5f24-4495-9367-3042410b8ff2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ki Rush",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f83dfd9-bbdc-4bcc-b37f-2a8c89bf7bab"), Type = TextBlockType.Text, Text = "Accelerated by your ki, you move with such speed you become a blur. Move two times: two Strides, two Steps, or one Stride and one Step (in either order). You gain the concealed condition during this movement and until the start of your next turn." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1ed91d7b-3f37-4e84-828b-3d428e058209"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("4c607fff-13fe-45c0-9d2f-f97f20350c43"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("59764c3b-fde3-43fd-9f88-17799d6bc26b"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4c331e6-e586-45b6-bd2c-4d1d5f3aeacb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 401
            };
        }
    }
}
