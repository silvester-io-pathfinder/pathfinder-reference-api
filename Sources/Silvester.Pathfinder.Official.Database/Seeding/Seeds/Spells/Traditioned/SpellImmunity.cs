using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SpellImmunity : Template
    {
        public static readonly Guid ID = Guid.Parse("cf7057ec-301d-435b-904f-f4938c87e4bc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spell Immunity",
                Level = 4,
                Range = "Touch.",
                Duration = "24 hours.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("45a3b160-448c-442d-bce7-586d2858daeb"), Type = TextBlockType.Text, Text = "You ward a creature against the effects of a single spell. Choose a spell and name it aloud as part of the verbal component. Spell immunity attempts to counteract that spell whenever spell immunity’s target is the target of the named spell or in that spell’s area. Successfully counteracting a spell that targets an area or multiple targets with spell immunity negates the effects only for the target affected by spell immunity." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9153905f-8af8-4da5-af1b-ca7af54585a7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 371
            };
        }
    }
}
