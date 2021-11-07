using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReachForTheStars : Template
    {
        public static readonly Guid ID = Guid.Parse("cf38e0d5-bd6f-4d0d-8bb2-564360c8bd4e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reach for the Stars",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("53ec6c94-91d0-409f-b0d5-140c70d16757"), Type = TextBlockType.Text, Text = "The sky’s the limit, as long as you’ve got enough black powder. When you use (feat: Black Powder Boost), you can expend additional black powder or ammunition to boost yourself farther. For each dose of black powder or piece of firearm ammunition you spend in addition to your shot, you add another 10 feet to the height or distance of your Leap, to a maximum of 5 boosts (a +50-foot status bonus). You must be wearing a dose of black powder or piece of ammunition, or have it in hand, to detonate it for a boost." };
            yield return new TextBlock { Id = Guid.Parse("ba9b88fe-d0cf-4c45-a0f6-3ebbafe1cc6c"), Type = TextBlockType.Text, Text = "You can choose at which points in your (action: Leap) you detonate each boost, allowing you to change direction each time. You must then move in a straight line until you boost again or end your (action: Leap)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4a357306-dad7-4bc1-9af2-4131da2fa50d"), Feats.Instances.BlackPowderBoost.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("189b3037-43dd-4301-8283-8f3a94f72df7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
