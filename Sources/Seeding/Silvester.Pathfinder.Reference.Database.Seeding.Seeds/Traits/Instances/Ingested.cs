using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Ingested : Template
    {
        public static readonly Guid ID = Guid.Parse("1fe62d2e-464f-4972-95a2-d82d4b0dc4b3");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Ingested",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0132589-2177-40c9-b603-bb1fca12400f"), Type = TextBlockType.Text, Text = "This poison is delivered when drunk or eaten." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a92362c3-0d6e-40b4-884d-420692a1b979"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
