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
        public static readonly Guid ID = Guid.Parse("a41419e3-2715-4a8a-bcd5-2c657e404225");

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
            yield return new TextBlock { Id = Guid.Parse("0fb8869c-118c-479b-80c2-c9e76e292314"), Type = TextBlockType.Text, Text = "Your patron and familiar teach you special spells called hexes. A hex is a short-term effect drawn directly from your patron's magic. As such, you can cast only one hex each turn; attempts to cast a second hex spell on that turn fail and the spellcasting actions are lost." };
            yield return new TextBlock { Id = Guid.Parse("a5c01a2e-3e78-416c-b682-657eed98a9c9"), Type = TextBlockType.Text, Text = "Hexes are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool during your daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the Refocus activity to commune with your familiar. Focus spells are automatically heightened to half your level rounded up." };
            yield return new TextBlock { Id = Guid.Parse("d6c9c5b0-a5e5-4977-9053-e2496659198e"), Type = TextBlockType.Text, Text = "Focus spells don't require spell slots, and you can't cast them using spell slots. Certain feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 Focus Points. The full rules for focus spells appear here." };
            yield return new TextBlock { Id = Guid.Parse("5c1c5887-9032-4284-ad8f-71135154519c"), Type = TextBlockType.Text, Text = "You learn the phase familiar hex, which you can cast as a reaction to protect your familiar from harm. You learn most other hexes from witch lessons." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainFocusPoolPoint(Guid.Parse("64190fad-63e4-4733-8239-e900f5e225f5"));
            builder.GainSpecificSpell(Guid.Parse("54b7de72-78f8-450a-99eb-6afd2b83a10c"), Spells.Instances.PhaseFamiliar.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1dfd8b98-f577-4f3d-ac38-c97acbac07f5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 97
            };
        }
    }
}
