using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Drained : Template
    {
        public static readonly Guid ID = Guid.Parse("a263fc00-a122-416e-8213-a7214fa9a30f");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Drained",
                ConditionCategoryId = ConditionCategories.Instances.LoweredAbilities.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("89509236-9bb3-418e-be29-e31380949594"), Type = Utilities.Text.TextBlockType.Text, Text = "When a creature successfully drains you of blood or life force, you become less healthy. Drained always includes a value. You take a status penalty equal to your drained value on Constitution-based checks, such as Fortitude saves. You also lose a number of Hit Points equal to your level (minimum 1) times the drained value, and your maximum Hit Points are reduced by the same amount. For example, if you’re hit by an effect that inflicts drained 3 and you’re a 3rd-level character, you lose 9 Hit Points and reduce your maximum Hit Points by 9. Losing these Hit Points doesn’t count as taking damage." };
            yield return new TextBlock { Id = Guid.Parse("0b8cf255-bc93-4438-ad6d-efba1a02255e"), Type = Utilities.Text.TextBlockType.Text, Text = "Each time you get a full night’s rest, your drained value decreases by 1. This increases your maximum Hit Points, but you don’t immediately recover the lost Hit Points." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("322bb3f0-b548-4f39-893f-1754529921ed"),
                SourceId = CoreRulebook.ID,
                Page = 619
            };
        }
    }
}
