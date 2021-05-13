using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class City : Template
    {
        public static readonly Guid ID = Guid.Parse("4f98f4a5-3bc6-44b2-8e81-c5c6939d9253");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "City",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("38f44cf7-5a68-43a7-955e-7773b32a099a"), Type = TextBlockType.Text, Text = "Settlements with this trait tend to be relatively large, with levels typically ranging from 5 to 7." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce214c7c-1e3f-4857-a1a4-fc5231d5122a"),
                SourceId = GamemasteryGuide.ID,
                Page = 250
            };
        }
    }
}
