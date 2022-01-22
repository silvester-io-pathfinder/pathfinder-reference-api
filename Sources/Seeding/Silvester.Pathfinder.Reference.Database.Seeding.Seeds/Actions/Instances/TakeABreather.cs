using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances
{
    public class TakeABreather : Template
    {
        public static readonly Guid ID = Guid.Parse("a726427c-43a9-4a34-aff0-d9e3f1f740e0");

        protected override Models.Entities.Action GetAction()
        {
            return new Models.Entities.Action
            {
                Id = ID,
                Name = "Take a Breather",
                Requirements = "1 Resolve Point.",
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5d116f51-d286-46bf-b8e4-e322befca1bf"), Text = "You rest for 10 minutes and recover your stamina. After you complete this activity, you regain all your Stamina Points." };
        }
    }
}
