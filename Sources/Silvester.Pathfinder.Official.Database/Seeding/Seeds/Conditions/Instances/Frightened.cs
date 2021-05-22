using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Frightened : Template
    {
        public static readonly Guid ID = Guid.Parse("06cdc6c0-2d59-414e-a1bf-1d1862bae2d7");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Frightened",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b7dabd8d-11d5-4498-a799-c904741c3619"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re gripped by fear and struggle to control your nerves. The frightened condition always includes a value. You take a status penalty equal to this value to all your checks and DCs. Unless specified otherwise, at the end of each of your turns, the value of your frightened condition decreases by 1." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf8fd91d-d02e-460e-81c7-6745f5b46690"),
                SourceId = CoreRulebook.ID,
                Page = 620
            };
        }
    }
}
