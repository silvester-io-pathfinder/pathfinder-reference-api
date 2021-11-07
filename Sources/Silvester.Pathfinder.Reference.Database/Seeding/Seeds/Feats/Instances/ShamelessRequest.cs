using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShamelessRequest : Template
    {
        public static readonly Guid ID = Guid.Parse("f686498d-9393-47f0-ae0c-b1cca6c3264a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shameless Request",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42a144e1-9557-4b0f-90ed-37a271ede85d"), Type = TextBlockType.Text, Text = "You can downplay the consequences or outrageousness of your requests using sheer brazenness and charm. When you (action: Request) something, you reduce any DC increases for making an outrageous request by 2, and if you roll a critical failure for your (action: Request), you get a failure instead. While this means you can never cause your target to reduce their attitude toward you by making a (action: Request), they eventually tire of requests, even though they still have a positive attitude toward you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("51530802-6d14-4d58-bbf4-10feb56c5197"), Proficiencies.Instances.Master.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcb6d13c-3538-4ec3-8f54-68c0c6c3c4ae"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
