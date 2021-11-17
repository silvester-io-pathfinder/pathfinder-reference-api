using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Fleeing : Template
    {
        public static readonly Guid ID = Guid.Parse("35e06ece-e68a-4201-a215-8e3a29f30840");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Fleeing",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92d8268f-caec-4b0e-abe6-3d325bf3746e"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re forced to run away due to fear or some other compulsion. On your turn, you must spend each of your actions trying to escape the source of the fleeing condition as expediently as possible (such as by using move actions to flee, or opening doors barring your escape). The source is usually the effect or caster that gave you the condition, though some effects might define something else as the source. You can’t Delay or Ready while fleeing." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2e6c0f8-283e-4580-bec2-26abf8b586e7"),
                SourceId = CoreRulebook.ID,
                Page = 620
            };
        }
    }
}
