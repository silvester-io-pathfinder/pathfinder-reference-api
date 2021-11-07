using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Winglets : Template
    {
        public static readonly Guid ID = Guid.Parse("7aae5d17-4dd0-4c9c-a589-cb3692fec298");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Winglets",
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
            yield return new TextBlock { Id = Guid.Parse("73112c7f-b8f5-474d-a931-21e8b41b9954"), Type = TextBlockType.Text, Text = "You’re among the few kobolds who grow a set of draconic wings later in life. The wings are initially small and weak; while not enough for full flight, a strong flap allows you to jump further. When (action: Leaping | Leap) horizontally, you move an additional 5 feet (this additional distance isn’t cumulative with the increased (action: Leap) distance from the (feat: Powerful Leap) feat). You don’t automatically fail your checks to (action: High Jump) or (action: Long Jump) if you don’t (action: Stride) at least 10 feet first. In addition, when you attempt a (action: Long Jump), you can jump a distance up to 10 feet higher than you normally would based on the result of your Athletics check, though you still can’t jump farther than your Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("604bffed-2680-4f44-acfa-9571ddd7aac1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
