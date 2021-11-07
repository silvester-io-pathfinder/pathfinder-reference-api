using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JanatimosLessons : Template
    {
        public static readonly Guid ID = Guid.Parse("4abcd782-8c6c-49c5-81f0-17f3f351d5ac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Janatimo's Lessons",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("48481736-e2ae-4f97-bb71-70ec328ba7cb"), Type = TextBlockType.Text, Text = "Thanks to Janatimo’s secret techniques, you can weave your knowledge and words into powerful tools to assist your allies in life-threatening situations. When you use (feat: Uzunjati Recollection) to tell a story and (action: Recall Knowledge) about a creature during a combat encounter, if you succeed at both checks, your story carries deeper meaning. This grants your allies a +1 circumstance bonus to their next attack roll and saving throw against the creature during that encounter, as well as to their AC against that creature’s next attack roll during that encounter. If you critically succeed at both checks, the bonuses also apply to all attack rolls, saves, and AC against that creature for 2 rounds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4753783d-a8a9-4773-b9ae-a2e83b69a3a9"), Feats.Instances.UzunjatiRecollection.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("97aaef4e-9543-4091-8f87-af18bf758bfc"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
