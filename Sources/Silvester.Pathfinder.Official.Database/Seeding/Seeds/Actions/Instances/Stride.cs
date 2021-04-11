using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class Stride : AbstractActionTemplate
    {
        public static readonly Guid ID = Guid.Parse("4293eca5-4b6c-42f2-8e22-cd09796984fd");

        protected override Models.Action GetAction(ActionSeeder seeder)
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Stride",
                ActionTypeId = seeder.GetActionType("One Action"),
            };
        }

        protected override IEnumerable<ActionDetailsBlock> GetDetails(ActionSeeder seeder)
        {
            yield return new ActionDetailsBlock { Id = Guid.Parse("829f3140-7228-4996-8315-8302402acf15"), Text = "You move up to your Speed." };
        }

        protected override IEnumerable<Trait> GetTraits(ActionSeeder seeder)
        {
            yield return seeder.GetTrait("Move");
        }
    }
}
