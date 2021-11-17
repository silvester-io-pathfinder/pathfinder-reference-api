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
        public static readonly Guid ID = Guid.Parse("cec5aaf0-72c5-4420-b637-a786229a6557");
        
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
            builder.GainSpecificSkillProficiency(Guid.Parse("8f5e5a3e-647a-4630-844e-a8d46d89c499"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
            builder.GainSpecificFeat(Guid.Parse("dd0970b7-8b39-4c9b-8192-93afb5bba5fb"), Feats.Instances.FascinatingPerformance.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("075b2fd9-4660-4b28-970c-211465819a8e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 84
            };
        }
    }
}
