using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Hidden : Template
    {
        public static readonly Guid ID = Guid.Parse("4f1b10d8-98e2-43f2-b3a4-22e6b11ea699");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Hidden",
                ConditionCategoryId = ConditionCategories.Instances.DegreesOfDetection.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1b0fb05d-5c1a-429c-9a8e-65729fa82c9e"), Type = Utilities.Text.TextBlockType.Text, Text = "While you’re hidden from a creature, that creature knows the space you’re in but can’t tell precisely where you are. You typically become hidden by using Stealth to Hide. When Seeking a creature using only imprecise senses, it remains hidden, rather than observed. A creature you’re hidden from is flat-footed to you, and it must succeed at a DC 11 flat check when targeting you with an attack, spell, or other effect or it fails to affect you. Area effects aren’t subject to this flat check." };
            yield return new TextBlock { Id = Guid.Parse("891ef18a-15d1-4256-b2b9-c67320503e38"), Type = Utilities.Text.TextBlockType.Text, Text = "A creature might be able to use the Seek action to try to observe you, as described on page 471." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9af352ee-666e-46a3-a976-2d1f0be4bef5"),
                SourceId = CoreRulebook.ID,
                Page = 620
            };
        }
    }
}
