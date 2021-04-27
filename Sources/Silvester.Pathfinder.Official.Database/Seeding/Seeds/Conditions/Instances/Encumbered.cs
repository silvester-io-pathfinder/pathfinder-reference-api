using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Encumbered : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("5da2ad79-54a0-429e-a52a-d654841fb268");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Encumbered",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("29645e9c-1185-49a9-be03-ff02cd827421"), Type = Utilities.Text.TextBlockType.Text, Text = "You are carrying more weight than you can manage. While you’re encumbered, you’re clumsy 1 and take a 10-foot penalty to all your Speeds. As with all penalties to your Speed, this can’t reduce your Speed below 5 feet." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ca1a968-dcb9-4353-b15e-e397cda35b48"),
                SourceId = CoreRulebook.ID,
                Page = 619
            };
        }
    }
}
