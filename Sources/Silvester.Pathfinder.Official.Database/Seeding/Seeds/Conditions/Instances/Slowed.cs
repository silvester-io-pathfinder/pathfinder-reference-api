using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Slowed : Template
    {
        public static readonly Guid ID = Guid.Parse("f253f20f-d7d3-4fe6-bb19-8d521afd9436");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Slowed",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("54bff588-112b-46db-a7b9-eeeaf955a417"), Type = Utilities.Text.TextBlockType.Text, Text = "You have fewer actions. Slowed always includes a value. When you regain your actions at the start of your turn, reduce the number of actions you regain by your slowed value. Because slowed has its effect at the start of your turn, you don’t immediately lose actions if you become slowed during your turn." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32ddb040-0f69-40b1-8c45-693df9034766"),
                SourceId = CoreRulebook.ID,
                Page = 622
            };
        }
    }
}
