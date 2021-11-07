using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlamboyantLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("8545a0ac-9546-4d72-90e7-bae3ddb5b84e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flamboyant Leap",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ef0474ba-f627-4412-bdb0-cc47e2a27462"), Type = TextBlockType.Text, Text = "You stylishly leap and deliver a powerful finisher. Make a (action: Leap), (action: High Jump), or (action: Long Jump) and attempt one single-action finisher at any point during your jump; the finisher can’t be one that includes other movement, such as (feat: Mobile Finisher). Immediately after the finisher, you fall to the ground if you’re in the air, even if you haven’t reached the maximum distance of your jump. If the distance you fall is no more than the height of your jump, you take no damage and land upright. When attempting a (action: High Jump) or (action: Long Jump) during a Flamboyant Leap, determine the DC using the (action: Long Jump) DCs, and increase the maximum distance to double your Speed, rather than just your Speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("038f5c34-248b-457e-a7f6-54a8e88d47e8"), Proficiencies.Instances.Master.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificFeat(Guid.Parse("23cd1906-0269-4552-b667-fe6db01626eb"), Feats.Instances.FlamboyantAthlete.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e147a21b-b71a-404a-8797-b77ac3718a67"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
