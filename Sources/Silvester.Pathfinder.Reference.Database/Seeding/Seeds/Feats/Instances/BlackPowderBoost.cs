using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlackPowderBoost : Template
    {
        public static readonly Guid ID = Guid.Parse("ebc1ddf2-fd4a-4882-83e0-4b8e7e7df6a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Black Powder Boost",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "An ability that allows you to High Jump or Long Jump as a single action (like the Quick Jump skill feat) lets you use Black Powder Boost as a single action for those jumps as well.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c235730-e027-405b-a666-a04b38f48303"), Type = TextBlockType.Text, Text = "You fire your weapon as you jump, using the kickback to go farther. You (action: Leap) and discharge your firearm to add a +10-foot status bonus to the distance traveled. If you spend 2 actions for Black Powder Boost, you (action: High Jump) or (action: Long Jump) instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ba78138-7575-4ad4-9147-a0e865a74d60"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
