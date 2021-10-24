using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Stunned : Template
    {
        public static readonly Guid ID = Guid.Parse("4d045584-3a7f-433b-ad89-0f658c379923");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Stunned",
                OverridesConditionId = Slowed.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("48e84c47-e07c-479e-944f-d07f45cc88d4"), Type = Utilities.Text.TextBlockType.Text, Text = "You’ve become senseless. You can’t act while stunned. Stunned usually includes a value, which indicates how many total actions you lose, possibly over multiple turns, from being stunned. Each time you regain actions (such as at the start of your turn), reduce the number you regain by your stunned value, then reduce your stunned value by the number of actions you lost. For example, if you were stunned 4, you would lose all 3 of your actions on your turn, reducing you to stunned 1; on your next turn, you would lose 1 more action, and then be able to use your remaining 2 actions normally. Stunned might also have a duration instead of a value, such as “stunned for 1 minute.” In this case, you lose all your actions for the listed duration." };
            yield return new TextBlock { Id = Guid.Parse("ad411fa0-9af4-4d4e-ac38-00993975437a"), Type = Utilities.Text.TextBlockType.Text, Text = "Stunned overrides slowed. If the duration of your stunned condition ends while you are slowed, you count the actions lost to the stunned condition toward those lost to being slowed. So, if you were stunned 1 and slowed 2 at the beginning of your turn, you would lose 1 action from stunned, and then lose only 1 additional action by being slowed, so you would still have 1 action remaining to use that turn." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81b59165-360f-4844-909f-bdff6fe8da0b"),
                SourceId = CoreRulebook.ID,
                Page = 622
            };
        }
    }
}
