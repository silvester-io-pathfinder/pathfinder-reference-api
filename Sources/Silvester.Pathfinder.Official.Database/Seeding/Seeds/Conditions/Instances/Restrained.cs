using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Restrained : Template
    {
        public static readonly Guid ID = Guid.Parse("ecb312a5-4e27-43b9-89ec-1a615d9f9dc2");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Restrained",
                OverridesConditionId = Grabbed.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39067593-a781-4b58-a74a-175b8458e81e"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re tied up and can barely move, or a creature has you pinned. You have the flat-footed and immobilized conditions, and you can’t use any actions with the attack or manipulate traits except to attempt to Escape or Force Open your bonds. Restrained overrides grabbed." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de1236fc-c4e3-4f46-b8e3-1f3e06b2314d"),
                SourceId = CoreRulebook.ID,
                Page = 622
            };
        }
    }
}
