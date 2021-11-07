using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JustTheFacts : Template
    {
        public static readonly Guid ID = Guid.Parse("b889048b-39fb-4c06-a1dd-fffb75d32a8a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Just the Facts",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08510e2f-def5-4426-9c4a-499170112d88"), Type = TextBlockType.Text, Text = "You fundamentally understand everything to the point where your research can&#39;t possibly be wrong. You are permanently quickened and can use the extra action only to (action: Recall Knowledge). Your checks to (action: Recall Knowledge) are no longer (trait: secret). When you (action: Recall Knowledge), you use the outcome for one degree of success better than the result of your check, and if an effect (such as (feat: Dubious Knowledge)) would give you inaccurate information from your (action: Recall Knowledge) check, you know which information is inaccurate. When one of your allies (action: Recalls Knowledge | Recall Knowledge) and gains false information, you also know that information is inaccurate if they share it with you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("32c7bd4b-a7ac-424a-8110-955bf093c268"), Feats.Instances.ThoroughResearch.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de341dc7-b057-459e-8a8c-328acb515ce7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
