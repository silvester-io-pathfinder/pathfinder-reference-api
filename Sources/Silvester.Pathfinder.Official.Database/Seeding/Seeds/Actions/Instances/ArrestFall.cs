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
    public class ArrestFall : AbstractActionTemplate
    {
        public static readonly Guid ID = Guid.Parse("3367ce7a-8cc0-11eb-8dcd-0242ac130003");

        protected override Models.Action GetAction(ActionSeeder seeder)
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Arrest Fall",
                Trigger = "You fall.",
                Requirements = "You have a fly speed.",
                ActionTypeId = seeder.GetActionType("Reaction"),
            };
        }

        protected override IEnumerable<TextBlock> GetDetails(ActionSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("386cc768-8cc0-11eb-8dcd-0242ac130003"), Text = "You attempt an Acrobatics check to slow your fall. The DC is typically 15, but it might be higher due to air turbulence or other circumstances." };
        }

        protected override RollableEffect? GetRollableEffect(ActionSeeder seeder)
        {
            return new RollableEffect
            {
                Id = Guid.Parse("3d116422-8cc0-11eb-8dcd-0242ac130003"),
                Success = "You fall gently, taking no damage from the fall.",
            };
        }
    }
}
