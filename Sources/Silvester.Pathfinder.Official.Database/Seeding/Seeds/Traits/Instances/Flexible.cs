using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Flexible : Template
    {
        public static readonly Guid ID = Guid.Parse("42f5364e-7923-4d7e-affc-d71e511e2369");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Flexible",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("acb79433-e007-475c-87f4-616d32f8024b"), Type = TextBlockType.Text, Text = "The armor is flexible enough that it doesn’t hinder most actions. You don’t apply its check penalty to Acrobatics or Athletics checks." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0491b8a6-3959-4757-b7b3-be543988c983"),
                SourceId = CoreRulebook.ID,
                Page = 6275
            };
        }
    }
}
