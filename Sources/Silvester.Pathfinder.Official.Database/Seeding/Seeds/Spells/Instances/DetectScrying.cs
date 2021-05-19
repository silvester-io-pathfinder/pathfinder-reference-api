using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
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
                SpellTypeId = SpellTypes.Instances.Focus.ID,
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Detection.ID;
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 328
            };
        }
    }
}
