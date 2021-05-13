using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Inhaled : Template
    {
        public static readonly Guid ID = Guid.Parse("3df38b30-053a-4db0-9651-7bae935f2e38");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Inhaled",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("57a8813f-f2ae-4b7d-896a-1f1f0e24c9fa"), Type = TextBlockType.Text, Text = "This poison is delivered when breathed in." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7010f349-fb7e-4b6f-bb86-954f3bc80eab"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
