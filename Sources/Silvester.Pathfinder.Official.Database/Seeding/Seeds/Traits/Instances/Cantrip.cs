using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Cantrip : Template
    {
        public static readonly Guid ID = Guid.Parse("175c1a43-4b2b-4eb5-b767-fae273fbe109");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Cantrip",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ddb09201-e88f-4416-88d9-b6c385ed08c5"), Type = TextBlockType.Text, Text = "A spell you can cast at will that is automatically heightened to half your level rounded up." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0aa60ad-c2f5-4914-a4e8-22704b6fd073"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
