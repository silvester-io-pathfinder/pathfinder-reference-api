using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class Leap : AbstractActionTemplate
    {
        public static readonly Guid ID = Guid.Parse("99ab25a7-a541-4074-ae20-fb25b87520cd");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Leap",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2e208301-e15b-4adc-9929-d35835141a08"), Text = "You take a careful, short jump. You can Leap up to 10 feet horizontally if your Speed is at least 15 feet, or up to 15 feet horizontally if your Speed is at least 30 feet. You land in the space where your Leap ends (meaning you can typically clear a 5-foot gap, or a 10-foot gap if your Speed is 30 feet or more)." };
            yield return new TextBlock { Id = Guid.Parse("d4aeb760-f7a2-4095-bc96-e2f70ab49b80"), Text = "If you Leap vertically, you can move up to 3 feet vertically and 5 feet horizontally onto an elevated surface." };
            yield return new TextBlock { Id = Guid.Parse("6a431cbd-e07c-41e9-b824-179847fe0207"), Text = "Jumping a greater distance requires using the Athletics skill." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Move.ID;
        }
    }
}
