using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Immobilized : Template
    {
        public static readonly Guid ID = Guid.Parse("b335312b-5956-436b-a8df-c426704a41ba");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Immobilized",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eebe0f58-737c-4da3-a349-45e68247f56b"), Type = Utilities.Text.TextBlockType.Text, Text = "You can’t use any action with the move trait. If you’re immobilized by something holding you in place and an external force would move you out of your space, the force must succeed at a check against either the DC of the effect holding you in place or the relevant defense (usually Fortitude DC) of the monster holding you in place." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57922528-4da2-4416-8e4c-d460798e208c"),
                SourceId = CoreRulebook.ID,
                Page = 620
            };
        }
    }
}
