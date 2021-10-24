using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Spasming : Template
    {
        public static readonly Guid ID = Guid.Parse("d9b38c43-deee-4d47-a5a8-ee48ab4daa2d");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Spasming"
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("01f03109-d787-433a-afda-4b956c9a209e"), Type = Utilities.Text.TextBlockType.Text, Text = "You are conflicted with sudden spasms. The rulebooks do not mention any particular effects of spasming, so it is best left up to the discretion of the GM." };
        }

        public override SourcePage? GetSourcePage()
        {
            return null;
        }
    }
}
