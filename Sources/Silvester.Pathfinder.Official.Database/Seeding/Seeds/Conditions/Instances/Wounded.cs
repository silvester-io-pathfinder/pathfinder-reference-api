using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Wounded : Template
    {
        public static readonly Guid ID = Guid.Parse("8f6d81d5-64f1-455e-80c8-7835accb6613");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Wounded",
                ConditionCategoryId = ConditionCategories.Instances.DeathAndDying.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7101deb8-d849-472c-9ec6-13c6921c213e"), Type = Utilities.Text.TextBlockType.Text, Text = "You have been seriously injured. If you lose the dying condition and do not already have the wounded condition, you become wounded 1. If you already have the wounded condition when you lose the dying condition, your wounded condition value increases by 1. If you gain the dying condition while wounded, increase your dying condition value by your wounded value." };
            yield return new TextBlock { Id = Guid.Parse("0bfacc23-4b09-44c1-a157-49a246b3d704"), Type = Utilities.Text.TextBlockType.Text, Text = "The wounded condition ends if someone successfully restores Hit Points to you with Treat Wounds, or if you are restored to full Hit Points and rest for 10 minutes." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("344af983-0fdd-4623-be6c-59587595cfe5"),
                SourceId = CoreRulebook.ID,
                Page = 623
            };
        }
    }
}
