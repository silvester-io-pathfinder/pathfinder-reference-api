using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Sentient : Template
    {
        public static readonly Guid ID = Guid.Parse("858113c8-4744-4180-9315-8d5c4b47d929");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Sentient",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("24f75ee1-c9e7-4608-820c-13b67cf427df"), Type = TextBlockType.Text, Text = "Planes with this trait can change their physical nature according to the plane’s own whim." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b2bf9b7-a437-498e-b954-dba0e6e33c4b"),
                SourceId = GamemasteryGuide.ID,
                Page = 254
            };
        }
    }
}
