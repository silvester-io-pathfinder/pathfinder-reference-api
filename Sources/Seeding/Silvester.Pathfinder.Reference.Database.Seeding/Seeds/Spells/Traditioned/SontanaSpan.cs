using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SontanaSpan : Template
    {
        public static readonly Guid ID = Guid.Parse("f5908cc6-e936-4b0d-8e4e-29c0e7b48056");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sontana Span",
                Level = 2,
                Duration = "Sustained.",
                Area = "30-foot line.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a17dd32-0a04-4fab-9df8-42840f7a04ad"), Type = TextBlockType.Text, Text = "By playing a brief tune on an instrument or in song, you cause the notes of the melody to physically manifest into a shimmering, translucent path. This path doesn�t need to be over solid ground and can tilt up or down diagonally up to 45 degrees, but it must be a straight, 5-foot-wide line. It can support as many creatures as can physically fit on the bridge." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Sonic.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f83c7c8-7781-42a1-b9ab-d9f6cf19cd3b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 129
            };
        }
    }
}
