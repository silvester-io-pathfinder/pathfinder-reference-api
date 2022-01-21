using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HuntersLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("1a4d0c2e-af2c-4f4e-b974-16beb3fe7955");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hunter's Luck",
                Level = 2,
                Trigger = "You attempt a check to Recall Knowledge about a creature, but you haven't rolled yet.",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                ClassId = Classes.Instances.Ranger.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa2448d1-5f33-4249-bd0a-a8c4f3ff3132"), Type = TextBlockType.Text, Text = "You have a preternatural ability to remember details about your foes. Roll the triggering check twice and use the better result." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("8fa4f871-d871-42f0-90c8-6811c928f73c"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("387442de-e61a-4319-b06e-61684491800a"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("875ab21a-a3d7-41b6-8029-ae3339a55746"), Traits.Instances.Fortune.ID);
            builder.Add(Guid.Parse("7f94e351-3340-4629-91c2-b1f2d78c7fd4"), Traits.Instances.Ranger.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd770c05-f37d-42ce-8321-df34601aa71b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 235
            };
        }
    }
}
