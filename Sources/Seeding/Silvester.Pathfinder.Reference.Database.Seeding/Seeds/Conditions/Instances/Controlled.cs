using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Controlled : Template
    {
        public static readonly Guid ID = Guid.Parse("d4d10f5f-e6cc-4acc-a8b3-3a29de451366");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Controlled",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("672f53e9-c341-4d76-befe-8f2f97c3d693"), Type = Utilities.Text.TextBlockType.Text, Text = "Someone else is making your decisions for you, usually because you’re being commanded or magically dominated. The controller dictates how you act and can make you use any of your actions, including attacks, reactions, or even Delay. The controller usually does not have to spend their own actions when controlling you." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6317e26-779a-4558-afa5-525a9be21ca5"),
                SourceId = CoreRulebook.ID,
                Page = 618
            };
        }
    }
}
