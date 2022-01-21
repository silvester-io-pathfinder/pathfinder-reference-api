using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DetectScrying : Template
    {
        public static readonly Guid ID = Guid.Parse("2ef1bfc9-3ca3-45b8-804a-ba9d948224de");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Detect Scrying",
                Level = 4,
                Area = "30-foot emanation",
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cfb7389d-5dcb-4251-9f63-8285f2e85105"), Type = Utilities.Text.TextBlockType.Text, Text = "By tapping into trace divinatory auras, you detect the presence of scrying effects in the area. If detect scrying is higher level than a scrying effect, you gain a glimpse of the scrying creature and learn its approximate distance and direction." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("9e4831ac-5cfe-4a20-9583-6d18d37fa4d2"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("bf8ce5df-06bb-49f9-9c3f-7b0af705fff0"), Type = Utilities.Text.TextBlockType.Text, Text = "The duration is until the next time you make your daily preparations." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("4dd44d37-a48f-48c3-8428-3291ae25913b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("60a93b58-ca43-4fc6-8fb1-f3347d71e01d"), Traits.Instances.Detection.ID);
            builder.Add(Guid.Parse("1c61b5d0-a472-4b9e-92c1-86375451848a"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76d3dd77-a9b9-4e8a-8f48-dd6a1b029e9a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 328
            };
        }
    }
}
