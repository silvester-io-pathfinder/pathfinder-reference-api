using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeadClimber : Template
    {
        public static readonly Guid ID = Guid.Parse("0695f828-3a42-45a1-ad1d-f05f01868b48");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lead Climber",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("939f0287-64dc-4b33-8529-5f76d1fe70c5"), Type = TextBlockType.Text, Text = "When climbing, you can prepare routes for others to follow, and you can pull your allies up to avoid disaster. When your allies attempt to (action: Climb) a route you set using the (action: Follow the Expert) exploration activity, if any of them critically fail their checks to (action: Climb), you can attempt an Athletics check against the same DC. If you succeed, your ally fails instead of critically failing. If you also critically fail, you both experience the consequences of the critical failure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9d1ede2d-9cee-48de-95e7-dfab2d8b2ca6"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c23fe75-f502-404f-b2cd-a502a7035625"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
