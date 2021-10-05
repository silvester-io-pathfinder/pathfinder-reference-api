using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Ganzi : Template
    {
        public static readonly Guid ID = Guid.Parse("22cba2be-7f41-44bc-8727-0d5fe65df3d3");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Ganzi",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6ed4f00c-ac70-4614-a825-5b0fc486ec42"), Type = TextBlockType.Text, Text = "A planar scion descended from a chaotic being of the Maelstrom, such as a protean" };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37ccc443-f4cf-4b0f-991f-03cbf12627cc"),
                SourceId = AncestryGuide.ID,
                Page = 141
            };
        }
    }
}
