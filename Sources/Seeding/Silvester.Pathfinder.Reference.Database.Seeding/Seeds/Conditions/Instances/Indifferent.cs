using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Indifferent : Template
    {
        public static readonly Guid ID = Guid.Parse("f13e0f97-112a-4ffa-843a-00b406ee963d");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Indifferent",
                ConditionCategoryId = ConditionCategories.Instances.Attitudes.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("291d7186-938c-4caf-a163-8311f6fa9ce3"), Type = Utilities.Text.TextBlockType.Text, Text = "This condition reflects a creature's disposition toward a particular character, and only supernatural effects (like a spell) can impose this condition on a PC. A creature that is indifferent to a character doesn't really care one way or the other about that character. Assume a creature's attitude to a given character is indifferent unless specified otherwise." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d86c4397-fff6-431b-8de7-7e7c4024f050"),
                SourceId = CoreRulebook.ID,
                Page = 620
            };
        }
    }
}
