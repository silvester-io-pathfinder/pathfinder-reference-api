using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Sickened : Template
    {
        public static readonly Guid ID = Guid.Parse("c674e766-939d-47fa-9c94-80173d59741f");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Sickened",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8350c52-3a4a-44e0-89d0-6c5cd546bd5e"), Type = Utilities.Text.TextBlockType.Text, Text = "You feel ill. Sickened always includes a value. You take a status penalty equal to this value on all your checks and DCs. You can't willingly ingest anything—including elixirs and potions—while sickened." };
            yield return new TextBlock { Id = Guid.Parse("82673ddd-1dab-44ae-bb04-c8cc8c57d0a8"), Type = Utilities.Text.TextBlockType.Text, Text = "You can spend a single action retching in an attempt to recover, which lets you immediately attempt a Fortitude save against the DC of the effect that made you sickened. On a success, you reduce your sickened value by 1 (or by 2 on a critical success)." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b475166-4b71-4da5-b261-3b78d78adcde"),
                SourceId = CoreRulebook.ID,
                Page = 622
            };
        }
    }
}
