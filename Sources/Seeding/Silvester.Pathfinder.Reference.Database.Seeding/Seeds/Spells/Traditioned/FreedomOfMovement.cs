using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FreedomOfMovement : Template
    {
        public static readonly Guid ID = Guid.Parse("355246e2-8eea-42f1-8d4d-95c7df288737");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Freedom of Movement",
                Level = 4,
                Range = "Touch.",
                Duration = "10 minutes.",
                Targets = "1 creature touched.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b961480b-38e6-4356-aa02-c9ff234e2d10"), Type = TextBlockType.Text, Text = "You repel effects that would hinder a creature or slow its movement. While under this spell's effect, the target ignores effects that would give them a circumstance penalty to Speed. When they attempt to Escape an effect that has them immobilized, grabbed, or restrained, they automatically succeed unless the effect is magical and of a higher level than the freedom of movement spell." };
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f02496a-2918-4b4f-a75b-24906c8fd2a4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 340
            };
        }
    }
}
