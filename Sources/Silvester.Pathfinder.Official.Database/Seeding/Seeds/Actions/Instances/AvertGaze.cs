using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class AvertGaze : AbstractActionTemplate
    {
        public static readonly Guid ID = Guid.Parse("4384a058-8cc0-11eb-8dcd-0242ac130003");

        protected override Models.Action GetAction(ActionSeeder seeder)
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Avert Gaze",
                ActionTypeId = seeder.GetActionType("One Action"),
            };
        }

        protected override IEnumerable<TextBlock> GetDetails(ActionSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("1345cbb1-4a0d-47e6-918f-f09fa0bd859b"), Text = "You avert your gaze from danger. You gain a +2 circumstance bonus to saves against visual abilities that require you to look at a creature or object, such as a medusa’s petrifying gaze. Your gaze remains averted until the start of your next turn." };
        }
    }
}
