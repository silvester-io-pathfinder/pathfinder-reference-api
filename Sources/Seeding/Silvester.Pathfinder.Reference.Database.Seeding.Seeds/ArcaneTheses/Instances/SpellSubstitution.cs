using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArcaneTheses.Instances
{
    public class SpellSubstitution : Template
    {
        public static readonly Guid ID = Guid.Parse("7e1fcdb2-223d-45d5-9c11-8363f05edd36");

        protected override ArcaneThesis GetArcaneThesis()
        {
            return new ArcaneThesis
            {
                Id = ID, 
                Name = "Spell Substitution", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1da6f7d3-5e83-42b3-86a5-5e9acaf94949"), Type = TextBlockType.Text, Text = "You don't accept the fact that once spells are prepared, they can't be changed until your next daily preparation, and you have uncovered a shortcut allowing you to substitute new spells for those you originally prepared." };
            yield return new TextBlock { Id = Guid.Parse("46b31033-731c-4043-9167-7838f345e4b3"), Type = TextBlockType.Text, Text = "You can spend 10 minutes to empty one of your prepared spell slots and prepare a different spell from your spellbook in its place. If you are interrupted during such a swap, the original spell remains prepared and can still be cast. You can try again to swap out the spell later, but you must start the process over again." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("25a3c1ee-b38b-4af8-9c76-67f997d13c67"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 206
            };
        }
    }
}
