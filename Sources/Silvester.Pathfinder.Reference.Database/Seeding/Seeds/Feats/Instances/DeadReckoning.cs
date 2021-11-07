using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeadReckoning : Template
    {
        public static readonly Guid ID = Guid.Parse("c2136e19-5b89-4351-aee3-4888058e005e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dead Reckoning",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("febbb17b-c820-494f-9562-fc60e4f407a6"), Type = TextBlockType.Text, Text = "You&#39;ve trained yourself to maintain a strong sense of direction at all times, even when you can&#39;t use a (item: compass) or see the sky above. You immediately intuit which direction is north (assuming the concept of north exists at your current location)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9aaec1fc-5786-4d82-8244-1441f1acb190"), Feats.Instances.PathfinderAgentDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("f9cb7293-dcbd-47f9-96e3-371bfb88c29c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("893d1dca-a2fd-4f07-b251-fa8fc34f0cc8"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
