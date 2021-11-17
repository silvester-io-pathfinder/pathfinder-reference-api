using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Climbing : Template
    {
        public static readonly Guid ID = Guid.Parse("d052186d-62ce-46db-9ca9-b4e32aed43f4");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Climbing",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e3da4a63-d85b-47ed-a777-6b483a2545c4"), Type = TextBlockType.Text, Text = "The hand holding this weapon is freely available to Climb." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20022ebf-6f0f-41af-8595-df2de32274f1"),
                SourceId = AzarketiAncestryWebSupplement.ID,
                Page = 1
            };
        }
    }
}
