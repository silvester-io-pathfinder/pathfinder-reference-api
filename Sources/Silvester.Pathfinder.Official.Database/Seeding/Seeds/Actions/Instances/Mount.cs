using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class Mount : Template
    {
        public static readonly Guid ID = Guid.Parse("ab48c6d8-a194-4595-8358-c751fdc934d8");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Mount",
                Requirements = "You are adjacent to a creature that is at least one size larger than you and is willing to be your mount.",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("37cbf292-bc7b-46d3-909a-0bf344afe97b"), Text = "You move onto the creature and ride it. If you’re already mounted, you can instead use this action to dismount, moving off the mount into a space adjacent to it." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Move.ID;
        }
    }
}
