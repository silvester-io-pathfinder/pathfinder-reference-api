using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Invisible : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("b9db96ae-7d84-4616-8831-477d614b4dbd");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Invisible",
                ConditionCategoryId = ConditionCategories.Instances.Senses.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d7e6205-8464-4e8b-9909-0ddb38f7849d"), Type = Utilities.Text.TextBlockType.Text, Text = "While invisible, you can’t be seen. You’re undetected to everyone. Creatures can Seek to attempt to detect you; if a creature succeeds at its Perception check against your Stealth DC, you become hidden to that creature until you Sneak to become undetected again. If you become invisible while someone can already see you, you start out hidden to the observer (instead of undetected) until you successfully Sneak. You can’t become observed while invisible except via special abilities or magic." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7112785-1068-4ad7-8521-5a46dac22f3c"),
                SourceId = CoreRulebook.ID,
                Page = 620
            };
        }
    }
}
