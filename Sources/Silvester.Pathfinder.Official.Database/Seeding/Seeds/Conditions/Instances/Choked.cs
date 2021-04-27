using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Choked : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("9c93e839-3ea9-4baa-aada-951d8fbf9807");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Choked",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1066b273-a9bc-4fd4-82a4-604ccc824308"), Type = Utilities.Text.TextBlockType.Text, Text = "You are choked, either physically by something or someone, by something magical, or by the the effects of a disease or illness (such as coughing). You need to pass a flat DC check equal to the severity of the condition when you attempt to cast a spell that has a verbal component to it, or activate an item that has a command component to it." };
            yield return new TextBlock { Id = Guid.Parse("ade8b52a-1a01-4f58-b4e9-abf35f44e2d0"), Type = Utilities.Text.TextBlockType.Footnote, Text = "This is not an official status condition, but a pf2e.io liberty to smooth out some of the inconsistencies in the rulesbooks." };
        }

        public override SourcePage? GetSourcePage()
        {
            return null; 
        }
    }
}
