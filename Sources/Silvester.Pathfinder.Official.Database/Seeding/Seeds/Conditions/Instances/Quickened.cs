using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Quickened : Template
    {
        public static readonly Guid ID = Guid.Parse("fce417f7-0b9c-4d87-9f0a-45ae5d9a4e53");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Quickened",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0df66944-a5b6-40d4-a9ce-d00c4d2a0edb"), Type = Utilities.Text.TextBlockType.Text, Text = "You gain 1 additional action at the start of your turn each round. Many effects that make you quickened specify the types of actions you can use with this additional action. If you become quickened from multiple sources, you can use the extra action you’ve been granted for any single action allowed by any of the effects that made you quickened. Because quickened has its effect at the start of your turn, you don’t immediately gain actions if you become quickened during your turn." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ec62791-35c3-42a1-9840-eeae27f40c96"),
                SourceId = CoreRulebook.ID,
                Page = 622
            };
        }

        /*public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("080c64f0-6e98-49f4-9ed1-b7b39a2b5bb0"), Type = TextBlockType.Title, Text = "Gaining and Losing Actions" };
            yield return new TextBlock { Id = Guid.Parse("73e3d268-5f96-4ec1-b30e-243ed27e4749"), Type = TextBlockType.Text, Text = "Quickened, slowed, and stunned are the primary ways you can gain or lose actions on a turn. The rules for how this works appear on page 462. In brief, these conditions alter how many actions you regain at the start of your turn; thus, gaining the condition in the middle of your turn doesn’t adjust your number of actions on that turn. If you have conflicting conditions that affect your number of actions, you choose which actions you lose. For instance, the action gained from haste lets you only Stride or Strike, so if you need to lose one action because you’re also slowed, you might decide to lose the action from haste, letting you keep your other actions that can be used more flexibly." };
            yield return new TextBlock { Id = Guid.Parse("3e517663-a8da-4a37-b25d-42b26182d6a1"), Type = TextBlockType.Text, Text = "Some conditions prevent you from taking a certain subset of actions, typically reactions. Other conditions simply say you can’t act. When you can’t act, you’re unable to take any actions at all. Unlike slowed or stunned, these don’t change the number of actions you regain; they just prevent you from using them. That means if you are somehow cured of paralysis on your turn, you can act immediately." };
        }*/
    }
}
