using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Fascinated : Template
    {
        public static readonly Guid ID = Guid.Parse("33b600ff-067e-4a67-a1ce-c85cf2d2382c");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Fascinated",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a517c41-8680-4408-bbae-7bbc60409082"), Type = Utilities.Text.TextBlockType.Text, Text = "You are compelled to focus your attention on something, distracting you from whatever else is going on around you. You take a –2 status penalty to Perception and skill checks, and you can’t use actions with the concentrate trait unless they or their intended consequences are related to the subject of your fascination (as determined by the GM). For instance, you might be able to Seek and Recall Knowledge about the subject, but you likely couldn’t cast a spell targeting a different creature. This condition ends if a creature uses hostile actions against you or any of your allies." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1dbef0bc-4ffe-4e45-964f-83bbad2c884d"),
                SourceId = CoreRulebook.ID,
                Page = 619
            };
        }
    }
}
