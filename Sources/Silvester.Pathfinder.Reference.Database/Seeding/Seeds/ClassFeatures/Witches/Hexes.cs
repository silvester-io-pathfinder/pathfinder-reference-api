using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class Hexes : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Hexes", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your patron and familiar teach you special spells called hexes. A hex is a short-term effect drawn directly from your patron's magic. As such, you can cast only one hex each turn; attempts to cast a second hex spell on that turn fail and the spellcasting actions are lost." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Hexes are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool during your daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the Refocus activity to commune with your familiar. Focus spells are automatically heightened to half your level rounded up." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Focus spells don't require spell slots, and you can't cast them using spell slots. Certain feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 Focus Points. The full rules for focus spells appear here." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You learn the phase familiar hex, which you can cast as a reaction to protect your familiar from harm. You learn most other hexes from witch lessons." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainFocusPoolPoint(Guid.Parse(""));
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PhaseFamiliar.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 97
            };
        }
    }
}
