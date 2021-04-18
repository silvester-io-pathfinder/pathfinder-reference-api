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
    public class Aid : AbstractActionTemplate
    {
        public static readonly Guid ID = Guid.Parse("185abe1a-6c43-4884-bb8a-4f596e75442f");

        protected override Models.Action GetAction(ActionSeeder seeder)
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Aid",
                Trigger = "An ally is about to use an action that requires a skill check or attack roll.",
                Requirements = "The ally is willing to accept your aid, and you have prepared to help.",
                ActionTypeId = seeder.GetActionType("Reaction"),
            };
        }

        protected override IEnumerable<TextBlock> GetDetails(ActionSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("cb5d193c-21b9-44a4-8370-766b898ceae9"), Text = "You try to help your ally with a task. To use this reaction, you must first prepare to help, usually by using an action during your turn. You must explain to the GM exactly how you’re trying to help, and they determine whether you can Aid your ally." };
            yield return new TextBlock { Id = Guid.Parse("60fe2d98-ba32-435e-ac1c-1abb6e8a5691"), Text = "When you use your Aid reaction, attempt a skill check or attack roll of a type decided by the GM. The typical DC is 20, but the GM might adjust this DC for particularly hard or easy tasks. The GM can add any relevant traits to your preparatory action or to your Aid reaction depending on the situation, or even allow you to Aid checks other than skill checks and attack rolls." };
        }

        protected override RollableEffect? GetRollableEffect(ActionSeeder seeder)
        {
            return new RollableEffect
            {
                Id = Guid.Parse("5c94d039-e421-42b3-af86-d33a8f266410"),
                CriticalSuccess = " You grant your ally a +2 circumstance bonus to the triggering check. If you’re a master with the check you attempted, the bonus is +3, and if you’re legendary, it’s +4.",
                Success = "You grant your ally a +1 circumstance bonus to the triggering check.",
                CriticalFailure = "Your ally takes a –1 circumstance penalty to the triggering check."
            };
        }
    }
}
