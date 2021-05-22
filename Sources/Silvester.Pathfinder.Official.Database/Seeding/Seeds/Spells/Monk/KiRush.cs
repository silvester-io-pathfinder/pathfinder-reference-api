using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Monk.ID;
            yield return Traits.Instances.Transmutation.ID;
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
