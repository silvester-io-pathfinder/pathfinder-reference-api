using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Friendly : Template
    {
        public static readonly Guid ID = Guid.Parse("87851575-72a5-4935-b284-7cb0551fadf2");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Friendly",
                ConditionCategoryId = ConditionCategories.Instances.Attitudes.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44d2d929-9e51-4618-b433-df0633852619"), Type = Utilities.Text.TextBlockType.Text, Text = "This condition reflects a creature's disposition toward a particular character, and only supernatural effects (like a spell) can impose this condition on a PC. A creature that is friendly to a character likes that character. The character can attempt to make a Request of a friendly creature, and the friendly creature is likely to agree to a simple and safe request that doesn't cost it much to fulfill. If the character or one of their allies uses hostile actions against the creature, the creature gains a worse attitude condition depending on the severity of the hostile action, as determined by the GM." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22f3b334-9d9c-49fa-890f-e8a869daabc7"),
                SourceId = CoreRulebook.ID,
                Page = 620
            };
        }
    }
}
