using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Carrier : Template
    {
        public static readonly Guid ID = Guid.Parse("d1a95821-ef2b-4c73-8ec6-9ec6789c885d");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Carrier",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f1bac5d-e528-41a0-b36f-58e680f40a99"), Type = Utilities.Text.TextBlockType.Text, Text = "You are the carrier of a disease, but you do not yet experience symptoms." };
            yield return new TextBlock { Id = Guid.Parse("c9d257ad-4d93-463d-848b-feae9338886c"), Type = Utilities.Text.TextBlockType.Footnote, Text = "This is not an official status condition, but a pf2e.io liberty to smooth out some of the inconsistencies in the rulesbooks." };
        }

        public override SourcePage? GetSourcePage()
        {
            return null;
        }
    }
}
