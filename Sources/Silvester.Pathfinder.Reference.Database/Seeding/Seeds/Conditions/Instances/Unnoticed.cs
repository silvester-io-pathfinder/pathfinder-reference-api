using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Unnoticed : Template
    {
        public static readonly Guid ID = Guid.Parse("43bea701-97ae-4ab1-8e30-e42fcff51f41");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Unnoticed",
                ConditionCategoryId = ConditionCategories.Instances.DegreesOfDetection.ID,
                OverridesConditionId = Dazzled.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("02af347c-1d15-459a-88ce-3bd53bfcebdd"), Type = Utilities.Text.TextBlockType.Text, Text = "If you are unnoticed by a creature, that creature has no idea you are present at all. When you’re unnoticed, you’re also undetected by the creature. This condition matters for abilities that can be used only against targets totally unaware of your presence." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6136be14-61d3-44fa-9e44-f2a5006a6098"),
                SourceId = CoreRulebook.ID,
                Page = 623
            };
        }
    }
}
