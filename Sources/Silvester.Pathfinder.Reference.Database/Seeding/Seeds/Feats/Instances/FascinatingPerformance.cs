using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FascinatingPerformance : Template
    {
        public static readonly Guid ID = Guid.Parse("f41730fd-417c-4afb-b7ae-9e6a6050b1cc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fascinating Performance",
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
            yield return new TextBlock { Id = Guid.Parse("4f10da66-f027-4608-b69d-d7443d23ac1c"), Type = TextBlockType.Text, Text = "When you (Action: Perform), compare your result to the Will DC of one observer. If you succeed, the target is fascinated by you for 1 round. If the observer is in a situation that demands immediate attention, such as combat, you must critically succeed to fascinate it and the (Action: Perform) action gains the (trait: incapacitation) trait. You must choose which creature you’re trying to fascinate before you roll your check, and the target is then temporarily immune for 1 hour. If you’re an expert in Performance, you can fascinate up to four observers; if you’re a master, you can fascinate up to 10 observers; and if you’re legendary, you can fascinate any number of observers at the same time." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("78be5ec1-436b-4e34-9dd0-e1db911d0bf2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37036594-6743-4c6a-ad0d-383609448772"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
