using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CloudJump : Template
    {
        public static readonly Guid ID = Guid.Parse("8c1268f3-5dd3-4e21-a2a3-b8f3371c77ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cloud Jump",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22d15bd5-d36f-4245-8e5d-6b80960523ce"), Type = TextBlockType.Text, Text = "Your unparalleled athletic skill allows you to jump impossible distances. Triple the distance you (action: Long Jump) (so you could jump 60 feet on a successful DC 20 check). When you (action: High Jump), use the calculation for a (action: Long Jump) but don’t triple the distance." };
            yield return new TextBlock { Id = Guid.Parse("be78b203-1e27-433c-b7e4-30bc41689f2a"), Type = TextBlockType.Text, Text = "You can jump a distance greater than your Speed by spending additional actions when you (action: Long Jump) or (action: High Jump). For each additional action spent, add your Speed to the limit on how far you can (action: Leap)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5e0e2602-a541-4ad8-9aab-e27ad9653299"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27883bbb-e63f-4abc-8ea2-52c5a82642e1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
