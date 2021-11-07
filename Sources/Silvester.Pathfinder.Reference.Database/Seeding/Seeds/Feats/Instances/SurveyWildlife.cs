using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurveyWildlife : Template
    {
        public static readonly Guid ID = Guid.Parse("5c26a49c-f3dd-495e-a8c7-e94dcde39a18");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Survey Wildlife",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1058f9c3-c1d2-4d2d-aa7a-bf20458405d2"), Type = TextBlockType.Text, Text = "You can study details in the wilderness to determine the presence of nearby creatures. You can spend 10 minutes assessing the area around you to find out what creatures are nearby, based on nests, scat, and marks on vegetation. Attempt a Survival check against a DC determined by the GM based on how obvious the signs are. On a success, you can attempt a (Action: Recall Knowledge) check with a -2 penalty to learn more about the creatures just from these signs. If you’re a master in Survival, you don’t take the penalty." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("231d6540-03b4-4684-b2e9-b0ddde6e7abd"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a714aa2-5bc1-4fd0-bd08-5539231a4957"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
