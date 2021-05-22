using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Unfriendly : Template
    {
        public static readonly Guid ID = Guid.Parse("ca2e35fe-8529-4ba3-a860-1bbde1c1c8f8");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Unfriendly",
                ConditionCategoryId = ConditionCategories.Instances.Attitudes.ID,
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c738f0a6-bf21-43d4-a869-12019f22a359"), Type = Utilities.Text.TextBlockType.Text, Text = "This condition reflects a creature’s disposition toward a particular character, and only supernatural effects (like a spell) can impose this condition on a PC. A creature that is unfriendly to a character dislikes and specifically distrusts that character. The unfriendly creature won’t accept Requests from the character." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3eadd81e-0338-4b94-85a0-6939831d8396"),
                SourceId = CoreRulebook.ID,
                Page = 623
            };
        }
    }
}
