using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SlipWithTheBreeze : Template
    {
        public static readonly Guid ID = Guid.Parse("977f96b2-4388-4f49-bdac-7d65ecb45a2d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slip with the Breeze",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ef712062-3586-470c-9a79-3db3036582c0"), Type = TextBlockType.Text, Text = "You create gusts of wind when you jump, allowing you to carry yourself across greater distances. You gain the (feat: Quick Jump) and (feat: Powerful Leap) skill feats as bonus feats." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("162789a1-2fa0-4084-bf95-b0117cf77254"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9a07a55-1e10-474c-b48f-9ebaa9834093"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
