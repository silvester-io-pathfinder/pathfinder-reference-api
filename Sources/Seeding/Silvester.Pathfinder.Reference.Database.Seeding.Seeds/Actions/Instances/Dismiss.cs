using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances
{
    public class Dismiss : Template
    {
        public static readonly Guid ID = Guid.Parse("894c1efc-7e3a-4313-a6c3-04b8cf136780");

        protected override Models.Entities.Action GetAction()
        {
            return new Models.Entities.Action
            {
                Id = ID,
                Name = "Dismiss",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8be9faaf-e9c6-4336-96dd-fae366e08b4d"), Text = "You end one spell effect or magic item effect. This must be an effect you are allowed to dismiss, as defined by the spell or item. Dismissal might end the effect entirely or might end it just for a certain target or targets, depending on the spell or item." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
        }
    }
}
