using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Divine : Template
    {
        public static readonly Guid ID = Guid.Parse("5d679bee-63d6-4377-ae25-7ba3f82cb3b5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Divine",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31a55c3e-46ca-4765-9388-6b6f5383c154"), Type = TextBlockType.Text, Text = "This magic comes from the divine tradition, drawing power from deities or similar sources. Anything with this trait is magical." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cf9b91f-4863-4ff3-bd47-9fc96e709444"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
