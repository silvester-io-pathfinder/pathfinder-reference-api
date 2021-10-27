using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SwashbucklerStyles.Instances
{
    public class Battledancer : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override SwashbucklersStyle GetSwashbucklersStyle()
        {
            return new SwashbucklersStyle
            {
                Id = ID, 
                Name = "Battledancer",
                Description = "To you, a fight is a kind of performance art, and you command your foes' attention with mesmerizing motions. You are trained in Performance and gain the Fascinating Performance skill feat. You gain panache during an encounter when the result of your Performance check to Perform exceeds the Will DC of an observing foe, even if the foe isn't fascinated.",
                ExemplaryFinisher = "You can Step as a free action immediately after the finisher."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.FascinatingPerformance.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 84
            };
        }
    }
}
