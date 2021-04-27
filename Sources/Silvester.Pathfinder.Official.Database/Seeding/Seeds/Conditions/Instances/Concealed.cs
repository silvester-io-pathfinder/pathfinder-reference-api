using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Concealed : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("64d1cfdc-8539-4bf7-95f2-60d53788079b");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Concealed",
                ConditionCategoryId = ConditionCategories.Instances.Senses.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4747231a-c95e-488a-9cf8-6ebef9bfadfa"), Type = Utilities.Text.TextBlockType.Text, Text = "While you are concealed from a creature, such as in a thick fog, you are difficult for that creature to see. You can still be observed, but you’re tougher to target. A creature that you’re concealed from must succeed at a DC 5 flat check when targeting you with an attack, spell, or other effect. Area effects aren’t subject to this flat check. If the check fails, the attack, spell, or effect doesn’t affect you." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0a8e076-7eb6-4e69-a115-b30d318a100a"),
                SourceId = CoreRulebook.ID,
                Page = 618
            };
        }
    }
}
