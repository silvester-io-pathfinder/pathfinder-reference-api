using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Flourish : Template
    {
        public static readonly Guid ID = Guid.Parse("b7aca55c-9472-406d-b89a-ceeb5298e2db");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Flourish",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("43f8e776-2286-4ece-b430-0242db6820af"), Type = TextBlockType.Text, Text = "Flourish actions are actions that require too much exertion to perform a large number in a row. You can use only 1 action with the flourish trait per turn." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6700d53-25c9-4f32-b50a-69dfeb4573bc"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
