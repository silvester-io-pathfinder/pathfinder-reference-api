using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances
{
    public class Release : Template
    {
        public static readonly Guid ID = Guid.Parse("ed94ef79-c37c-4591-a520-557916925352");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Release",
                ActionTypeId = FreeAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4014c48b-23f3-4382-81c7-3b9e7c1eec47"), Text = "You release something you’re holding in your hand or hands. This might mean dropping an item, removing one hand from your weapon while continuing to hold it in another hand, releasing a rope suspending a chandelier, or performing a similar action. Unlike most manipulate actions, Release does not trigger reactions that can be triggered by actions with the manipulate trait (such as Attack of Opportunity)." };
            yield return new TextBlock { Id = Guid.Parse("168a4329-2ae8-48a5-8fa6-a5508a9b1b86"), Text = "If you want to prepare to Release something outside of your turn, use the Ready activity." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Manipulate.ID;
        }
    }
}
