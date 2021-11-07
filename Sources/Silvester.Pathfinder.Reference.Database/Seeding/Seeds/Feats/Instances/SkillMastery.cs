using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SkillMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("a3195117-7877-490b-8864-821b0f700ecc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skill Mastery",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat up to five times.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("17b9b75b-4ed1-4e80-8b15-e651b8d18853"), Type = TextBlockType.Text, Text = "Increase your proficiency rank in one of your skills from expert to master and in another of your skills from trained to expert. You gain a skill feat associated with one of the skills you chose." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("11d14e07-1a8b-4e48-b4e3-388edb729851"), Feats.Instances.InvestigatorDedication.ID);
            builder.HaveAnySkillSpecificProficiency(Guid.Parse("846d8c67-b8bd-4b6c-8af8-86d2e0e78607"), Proficiencies.Instances.Trained.ID);
            builder.HaveAnySkillSpecificProficiency(Guid.Parse("2ac94b72-10c9-49b8-8f6f-f8c15651ca36"), Proficiencies.Instances.Expert.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba2f2f87-bf94-42b6-8002-fb9b96b3583d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
