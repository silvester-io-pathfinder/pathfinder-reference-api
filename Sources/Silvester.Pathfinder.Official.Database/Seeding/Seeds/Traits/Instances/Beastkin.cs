using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Beastkin : Template
    {
        public static readonly Guid ID = Guid.Parse("6b2aa915-1a46-4102-acde-584ff5da33b3");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Beastkin",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4baab5e2-7ac1-4bc5-84e3-7989aa98571d"), Type = TextBlockType.Text, Text = "Humanoids that can partially or fully transform into animal forms." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("160a4b03-a70b-4593-8855-dfd857768206"),
                SourceId = AncestryGuide.ID,
                Page = 140
            };
        }
    }
}
