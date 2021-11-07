using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EyeOfOzem : Template
    {
        public static readonly Guid ID = Guid.Parse("945f31bc-9d28-477c-b9e7-847c3ebdc1c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eye of Ozem",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6e46117b-eb73-443b-bd1f-2043f213eea4"), Type = TextBlockType.Text, Text = "You’ve learned how to spot danger at a distance, allowing you to serve as a sentry with ease. You gain a +2 circumstance bonus to initiative rolls when using Perception, and when you’re (action: Scouting | Scout), you grant your allies a +2 circumstance bonus instead of +1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3fab4d8f-04f9-4f33-8ee9-6b3f141bb2ca"), Feats.Instances.LastwallSentryDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("e997ae74-5d20-4e39-8334-94a94a128f9c"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fc956e6-85db-4f37-9f9b-b7800c03684a"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
