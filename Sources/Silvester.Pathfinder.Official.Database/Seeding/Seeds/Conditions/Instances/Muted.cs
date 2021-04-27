using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Muted : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("b0cbbc02-bec0-4b21-9b61-8af5bb2fc62b");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Muted",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e35d6973-eac6-461b-92e8-8f12bbcbdb80"), Type = Utilities.Text.TextBlockType.Text, Text = "You are unable to communicate verbally with anyone. Additionally, you cannot cast any spells that have a verbal component to it, or activate an item that hase a command component to it." };
            yield return new TextBlock { Id = Guid.Parse("ae9953c8-e05c-4a5a-ad62-6958c0fa0478"), Type = Utilities.Text.TextBlockType.Footnote, Text = "This is not an official status condition, but a pf2e.io liberty to smooth out some of the inconsistencies in the rulesbooks." };
        }

        public override SourcePage? GetSourcePage()
        {
            return null;
        }
    }
}
