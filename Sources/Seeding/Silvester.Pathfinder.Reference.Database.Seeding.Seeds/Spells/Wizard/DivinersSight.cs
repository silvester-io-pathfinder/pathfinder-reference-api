using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DivinersSight : Template
    {
        public static readonly Guid ID = Guid.Parse("aa010c6e-dbb6-4c32-9206-6affd35f77a9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Diviner's Sight",
                Level = 1,
                Range = "30 feet.",
                Duration = "Until the end of your next turn.",
                Targets = "1 willing living creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("230e7f4d-e11a-48bd-ac0f-06c8f2178bf6"), Type = TextBlockType.Text, Text = "You glimpse into the target's future. Roll a d20; when the target attempts a non-secret saving throw or skill check, it can use the number you rolled instead of rolling, and the spell ends. Alternatively, you can instead reveal the result of the die roll for one of the target's secret checks during the duration, and the spell ends. Casting it again ends any active diviner's sight you have cast, as well as any active diviner's sight on the target." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b1830922-fe9c-4f8e-bda2-f65d9a23c2ed"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e04b8009-e715-4d24-b1f8-b5a9af3df3a8"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("1e0d97db-8aee-408a-9d6d-13a4e0bbb931"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("8064b7fb-f7c4-4e46-9ece-7e9ef65dc7e8"), Traits.Instances.Fortune.ID);
            builder.Add(Guid.Parse("b508d988-f73f-466d-a787-ce22be15c8f7"), Traits.Instances.Wizard.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22fd55f8-051f-4e5a-9d27-b71d886927fc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 406
            };
        }
    }
}
