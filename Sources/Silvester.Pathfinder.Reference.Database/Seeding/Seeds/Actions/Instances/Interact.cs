using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances
{
    public class Interact : Template
    {
        public static readonly Guid ID = Guid.Parse("b66bad20-3677-47eb-9344-c78e538adcd3");

        protected override Models.Entities.Action GetAction()
        {
            return new Models.Entities.Action
            {
                Id = ID,
                Name = "Interact",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3628f76a-d2f7-4391-9282-f7812e69ae26"), Text = "You use your hand or hands to manipulate an object or the terrain. You can grab an unattended or stored object, open a door, or produce some similar effect. You might have to attempt a skill check to determine if your Interact action was successful." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Manipulate.ID;
        }
    }
}
