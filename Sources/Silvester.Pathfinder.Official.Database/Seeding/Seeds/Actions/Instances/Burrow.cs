using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class Burrow : AbstractActionTemplate
    {
        public static readonly Guid ID = Guid.Parse("eb1f9f32-3d35-479a-a3e2-bf965e32fc3d");

        protected override Models.Action GetAction(ActionSeeder seeder)
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Burrow",
                Requirements = "You have a burrow speed.",
                ActionTypeId = seeder.GetActionType("One Action"),
            };
        }

        protected override IEnumerable<TextBlock> GetDetails(ActionSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("015a016b-90ec-42b1-9e9b-28c230d06999"), Text = "You dig your way through dirt, sand, or a similar loose material at a rate up to your burrow Speed. You can’t burrow through rock or other substances denser than dirt unless you have an ability that allows you to do so." };
        }

        protected override IEnumerable<Trait> GetTraits(ActionSeeder seeder)
        {
            yield return seeder.GetTrait("Move");
        }
    }
}
