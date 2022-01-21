using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LoremastersEtude : Template
    {
        public static readonly Guid ID = Guid.Parse("96a33e5e-8662-4342-86f3-c3bebd52b541");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Loremaster's Etude",
                Level = 1,
                Range = "30 feet.",
                Trigger = "You or an ally within range attempts a skill check to Recall Knowledge.",
                Targets = "You or the triggering ally.",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("437f0fc5-4c7f-4f18-88de-4c76a9cdecd2"), Type = TextBlockType.Text, Text = "You call upon your muse's deep mysteries, granting the target a greater ability to think and recall information. Roll the triggering Recall Knowledge skill check twice and use the better result." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a892e4ac-374a-4a7c-b4d0-74bcf48ee55e"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("820ac742-e7ff-40cd-b468-c393e951fee6"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("c8ec1010-3cbc-4b48-9058-8581956a594f"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("94b4ad79-e265-4a5b-bcee-01f1847827dc"), Traits.Instances.Fortune.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba9b72ff-6cd6-4583-9842-a11a44d2ba6e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 387
            };
        }
    }
}
