using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class WeighedDown : Template
    {
        public static readonly Guid ID = Guid.Parse("a2d387ce-eec5-439b-9e2e-2ef38f0ff3fb");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Weighed Down",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("105ba368-8a63-48a7-841a-8fa74fdea882"), Type = Utilities.Text.TextBlockType.Text, Text = "You are weighed down, either physically, magically or otherwise. You take a penalty to all your movement speeds, but your speed can never be reduced below 5 feet." };
            yield return new TextBlock { Id = Guid.Parse("4e6ccb82-52eb-49c5-975d-7fcb50e4ede5"), Type = Utilities.Text.TextBlockType.Footnote, Text = "This is not an official status condition, but a pf2e.io liberty to smooth out some of the inconsistencies in the rulesbooks." };
        }

        public override SourcePage? GetSourcePage()
        {
            return null;
        }
    }
}
