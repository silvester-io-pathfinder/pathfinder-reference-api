using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AngelicWings : Template
    {
        public static readonly Guid ID = Guid.Parse("656f109a-6b34-4ceb-8e24-04545b5f537b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Angelic Wings",
                Level = 3,
                Duration = "3 rounds.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f8bdeb20-938d-4e88-b020-1f18578ca5e3"), Type = TextBlockType.Text, Text = "Wings of pure light spread out from your back, granting you a fly Speed equal to your Speed. Your wings cast bright light in a 30-foot radius. When this spell's duration would end, if you're still flying, you float to the ground, as feather fall." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("656ba0e8-23bd-40e0-9186-20ce7b44b244"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2ce79d1a-1401-4f29-bc6d-9180e60b4411"), Type = TextBlockType.Text, Text = "The duration increases to 1 minute." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("3203f573-84f0-4910-9679-e8e9c33fee9c"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("37bec8d1-8f17-4858-9536-24279e0774f9"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("3b200e89-e9ab-45d7-b5c7-66438d103249"), Traits.Instances.Light.ID);
            builder.Add(Guid.Parse("20fdc4e9-66a8-4665-a5a4-53b80bb2e7e4"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d237f5b5-3043-48f3-aaea-95b0e3a593ce"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 403
            };
        }
    }
}
