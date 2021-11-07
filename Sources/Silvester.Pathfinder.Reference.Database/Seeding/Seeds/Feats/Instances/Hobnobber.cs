using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Hobnobber : Template
    {
        public static readonly Guid ID = Guid.Parse("66ccbc34-6e77-48fc-b39f-fd2146954827");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hobnobber",
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
            yield return new TextBlock { Id = Guid.Parse("2c3d3ae8-500e-4f12-bf75-9523024a27cd"), Type = TextBlockType.Text, Text = "You are skilled at learning information through conversation. The (action: Gather Information) exploration activity takes you half as long as normal (typically reducing the time to 1 hour). If you’re a master in Diplomacy and you (action: Gather Information) at the normal speed, when you attempt to do so and roll a critical failure, you get a failure instead. There is still no guarantee that a rumor you learn with (action: Gather Information) is accurate." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c078e3f3-7102-4260-99cb-b29786e290e1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85f6dd76-8588-4685-ab2a-b3e1be242f29"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
