using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Observed : Template
    {
        public static readonly Guid ID = Guid.Parse("6f1426bc-454d-4796-a6b5-a1569dd39ee6");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Observed",
                ConditionCategoryId = ConditionCategories.Instances.DegreesOfDetection.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a8a7135-4b51-4671-963e-e1c99a28a9fe"), Type = Utilities.Text.TextBlockType.Text, Text = "Anything in plain view is observed by you. If a creature takes measures to avoid detection, such as by using Stealth to Hide, it can become hidden or undetected instead of observed. If you have another precise sense instead of or in addition to sight, you might be able to observe a creature or object using that sense instead. You can observe a creature only with precise senses. When Seeking a creature using only imprecise senses, it remains hidden, rather than observed." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95b85300-604c-4e3c-853c-4699f676bc49"),
                SourceId = CoreRulebook.ID,
                Page = 621
            };
        }
    }
}
