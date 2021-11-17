using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances
{
    public class Burrow : Template
    {
        public static readonly Guid ID = Guid.Parse("eb1f9f32-3d35-479a-a3e2-bf965e32fc3d");

        protected override Models.Entities.Action GetAction()
        {
            return new Models.Entities.Action
            {
                Id = ID,
                Name = "Burrow",
                Requirements = "You have a burrow speed.",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("015a016b-90ec-42b1-9e9b-28c230d06999"), Text = "You dig your way through dirt, sand, or a similar loose material at a rate up to your burrow Speed. You can’t burrow through rock or other substances denser than dirt unless you have an ability that allows you to do so." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Move.ID;
        }
    }
}
