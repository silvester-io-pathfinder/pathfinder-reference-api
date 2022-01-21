using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class ExtremeCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("4987f226-0f9e-458d-ad52-b0cd5da23948");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Extreme Curse", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("77d2e05e-6a6b-4585-b775-a3d13705243c"), Type = TextBlockType.Text, Text = "You have mastered a perilous balance between the conflicting divine powers of your mystery, gaining the power to change your fate, but straining both body and soul. When you cast a revelation spell while affected by your major curse, your curse intensifies to an extreme effect instead of overwhelming you. All mysteries share the same effects for their extreme curse." };
            yield return new TextBlock { Id = Guid.Parse("3918f602-55f7-40d0-a97a-f408a84030d3"), Type = TextBlockType.Text, Text = "When affected by your extreme curse, you become doomed 2 (or increase your doomed condition by 2 if you were already doomed). Once every 10 minutes, when you fail an attack roll, skill or Perception check, or saving throw, you can reroll it and use the second result. The reroll has the fortune trait and doesn't require you to spend an action, meaning you can use the reroll even if you can't act. These effects are in addition to all the effects of your major curse, and they can't be removed by any means until you Refocus to reduce your curse to its minor effect." };
            yield return new TextBlock { Id = Guid.Parse("c6dcaccf-bc75-47d1-9014-8210b3c23760"), Type = TextBlockType.Text, Text = "If you cast a revelation spell while under the effects of this extreme curse, you are overwhelmed by your curse, and you remain doomed 2 even if you Refocus. Additionally, if you spend at least 3 Focus Points before you again Refocus, you recover 3 Focus Points when you Refocus instead of 1." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add Extreme Curse effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c7d248c-8122-4e90-8c77-1c9555e88e30"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 72
            };
        }
    }
}
