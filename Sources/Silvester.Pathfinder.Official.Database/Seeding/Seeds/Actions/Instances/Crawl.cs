using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class Crawl : Template
    {
        public static readonly Guid ID = Guid.Parse("5f770553-dac1-4377-8416-1a2a2e8f43be");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Crawl",
                Requirements = "You are prone and your Speed is at least 10 feet.",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ea4b9697-2a26-4b33-aa9d-f6908ab082e3"), Text = "You move 5 feet by crawling and continue to stay prone." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Move.ID;
        }
    }
}
