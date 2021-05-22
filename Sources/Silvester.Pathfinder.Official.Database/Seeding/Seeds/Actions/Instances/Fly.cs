using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class Fly : Template
    {
        public static readonly Guid ID = Guid.Parse("31fb2827-6ed7-455e-b135-9f4893b298fb");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Fly",
                Requirements = "You have a fly speed.",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a92602b3-303e-448f-91a1-8cf3dbce6c5a"), Text = "You move through the air up to your fly Speed. Moving upward (straight up or diagonally) uses the rules for moving through difficult terrain. You can move straight down 10 feet for every 5 feet of movement you spend. If you Fly to the ground, you don’t take falling damage. You can use an action to Fly 0 feet to hover in place. If you’re airborne at the end of your turn and didn’t use a Fly action this round, you fall." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Move.ID;
        }
    }
}
