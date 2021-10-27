using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances
{
    public class Delay : Template
    {
        public static readonly Guid ID = Guid.Parse("4163f1f7-245b-4989-b4a9-8638d75f2cdc");

        protected override Models.Entities.Action GetAction()
        {
            return new Models.Entities.Action
            {
                Id = ID,
                Name = "Delay",
                Trigger = "Your turn begins.",
                ActionTypeId = FreeAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f2def960-90a3-4293-9649-24a380ce33e5"), Text = "You wait for the right moment to act. The rest of your turn doesn’t happen yet. Instead, you’re removed from the initiative order. You can return to the initiative order as a free action triggered by the end of any other creature’s turn. This permanently changes your initiative to the new position. You can’t use reactions until you return to the initiative order. If you Delay an entire round without returning to the initiative order, the actions from the Delayed turn are lost, your initiative doesn’t change, and your next turn occurs at your original position in the initiative order." };
            yield return new TextBlock { Id = Guid.Parse("c9a4cd10-fd21-4bb9-a356-a47d4837599a"), Text = "When you Delay, any persistent damage or other negative effects that normally occur at the start or end of your turn occur immediately when you use the Delay action. Any beneficial effects that would end at any point during your turn also end. The GM might determine that other effects end when you Delay as well. Essentially, you can’t Delay to avoid negative consequences that would happen on your turn or to extend beneficial effects that would end on your turn." };
        }
    }
}
