using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class Ready : AbstractActionTemplate
    {
        public static readonly Guid ID = Guid.Parse("56d03917-ff05-4b95-9455-4cb2ccbc9a60");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Ready",
                ActionTypeId = TwoActions.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1a320b87-a7f6-4d18-b4e2-3ea5dd7008a6"), Text = "You prepare to use an action that will occur outside your turn. Choose a single action or free action you can use, and designate a trigger. Your turn then ends. If the trigger you designated occurs before the start of your next turn, you can use the chosen action as a reaction (provided you still meet the requirements to use it). You can’t Ready a free action that already has a trigger." };
            yield return new TextBlock { Id = Guid.Parse("23ce08c6-58c9-43a0-8028-aa462b266f98"), Text = "If you have a multiple attack penalty and your readied action is an attack action, your readied attack takes the multiple attack penalty you had at the time you used Ready. This is one of the few times the multiple attack penalty applies when it’s not your turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Concentrate.ID;
        }
    }
}
