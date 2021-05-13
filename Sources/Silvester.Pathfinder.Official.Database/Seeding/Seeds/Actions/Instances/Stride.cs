using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class Stride : Template
    {
        public static readonly Guid ID = Guid.Parse("4293eca5-4b6c-42f2-8e22-cd09796984fd");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Stride",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("829f3140-7228-4996-8315-8302402acf15"), Text = "You move up to your Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Move.ID;
        }
    }
}
