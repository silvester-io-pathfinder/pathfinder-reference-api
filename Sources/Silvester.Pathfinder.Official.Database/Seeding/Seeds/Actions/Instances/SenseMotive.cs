using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class SenseMotive : AbstractActionTemplate
    {
        public static readonly Guid ID = Guid.Parse("f715d730-9ad4-4922-b893-cda88fe25ea4");

        protected override Models.Action GetAction(ActionSeeder seeder)
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Sense Motive",
                ActionTypeId = seeder.GetActionType("One Action"),
            };
        }

        protected override IEnumerable<ActionDetailsBlock> GetDetails(ActionSeeder seeder)
        {
            yield return new ActionDetailsBlock { Id = Guid.Parse("65547cff-999a-493d-a6c1-4f56d3f0662a"), Text = "You try to tell whether a creature’s behavior is abnormal. Choose one creature, and assess it for odd body language, signs of nervousness, and other indicators that it might be trying to deceive someone. The GM attempts a single secret Perception check for you and compares the result to the Deception DC of the creature, the DC of a spell affecting the creature’s mental state, or another appropriate DC determined by the GM. You typically can’t try to Sense the Motive of the same creature again until the situation changes significantly." };
        }

        protected override IEnumerable<Trait> GetTraits(ActionSeeder seeder)
        {
            yield return seeder.GetTrait("Concentrate");
            yield return seeder.GetTrait("Secret");
        }

        protected override RollableEffect? GetRollableEffect(ActionSeeder seeder)
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e83cff43-911b-41f0-a5d3-e67bed0ca36b"),
                CriticalSuccess = "You determine the creature’s true intentions and get a solid idea of any mental magic affecting it.",
                Success = "You can tell whether the creature is behaving normally, but you don’t know its exact intentions or what magic might be affecting it.",
                Failure = "You detect what a deceptive creature wants you to believe. If they’re not being deceptive, you believe they’re behaving normally.",
                CriticalFailure = "You get a false sense of the creature’s intentions."
            };
        }
    }
}
