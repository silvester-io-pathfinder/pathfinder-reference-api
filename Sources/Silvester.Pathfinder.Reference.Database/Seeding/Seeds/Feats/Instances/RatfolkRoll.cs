using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RatfolkRoll : Template
    {
        public static readonly Guid ID = Guid.Parse("4bf27bed-3366-4bbc-8ea8-09ecadce4550");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ratfolk Roll",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0fa73ca1-604e-4753-be78-54b068602d18"), Type = TextBlockType.Text, Text = "Your ability to curl up into a tight ball comes in handy. You roll up into a ball and move up to four times your Speed in a straight line down an incline. If you reach the bottom of the incline or hit an obstacle during this first turn of movement, you stop rolling safely. Otherwise, you automatically keep rolling at this Speed during subsequent turns until you hit the bottom of the incline or an obstacle ends this movement (which can happen in the middle of your turn). You’re slowed 2 each turn after the first that you keep rolling, and if you hit an obstacle on a turn after the first, you and the obstacle both take 4d6 bludgeoning damage and you stop rolling." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c88bf50f-a2c9-4f3e-8376-1c0596e4e7ad"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
