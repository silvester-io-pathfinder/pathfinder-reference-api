using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class Stand : Template
    {
        public static readonly Guid ID = Guid.Parse("4deb6d4d-0808-4755-897e-412a0d6e1f21");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Stand",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d04ec0db-0e06-4422-963e-1161dcbc2ba9"), Text = "You stand up from prone." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Move.ID;
        }
    }
}
