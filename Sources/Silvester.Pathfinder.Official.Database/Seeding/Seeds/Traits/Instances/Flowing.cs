using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Flowing : Template
    {
        public static readonly Guid ID = Guid.Parse("dcdd20ec-597b-44f1-a3b3-a302edbf54a6");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Flowing",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4a989cdc-0c77-47eb-9bf2-2e8985155dc4"), Type = TextBlockType.Text, Text = "Planes with this trait have a flow of time that is consistently faster or slower than that of other planes." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8404c6e7-c54c-4d92-821b-9e7450ba1314"),
                SourceId = GamemasteryGuide.ID,
                Page = 251
            };
        }
    }
}
