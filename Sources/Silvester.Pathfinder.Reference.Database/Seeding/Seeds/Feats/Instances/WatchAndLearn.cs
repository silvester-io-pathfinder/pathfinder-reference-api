using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WatchAndLearn : Template
    {
        public static readonly Guid ID = Guid.Parse("41f9d3fd-df54-4497-b273-7975ab0f5dc3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Watch and Learn",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally you can see succeeds or critically succeeds at a Strength- or Dexterity-based skill check, using a skill in which you are untrained.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fb5f40c8-507a-48e3-8623-8b8eb0329a6f"), Type = TextBlockType.Text, Text = "Pathfinder agents serve as members of diverse teams with complementary skill sets. You are practiced at following the example of a more skilled ally to accomplish a wide variety of tasks. For the next minute you can add your level as a proficiency bonus to the observed skill check, even though you are untrained. This does not allow you to attempt trained actions using that skill unless you would otherwise be able to do so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8e01ce3d-0b50-4991-b92b-19444fe347f2"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60a18770-47ab-4f4b-b859-3e32797773d6"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
