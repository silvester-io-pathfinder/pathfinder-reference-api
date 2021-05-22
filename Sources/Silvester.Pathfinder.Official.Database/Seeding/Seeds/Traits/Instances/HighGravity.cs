using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class HighGravity : Template
    {
        public static readonly Guid ID = Guid.Parse("0694d5dd-47d5-469b-a1b8-a4215ca5e7a4");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "High Gravity",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a1514f9b-e252-4a70-b48a-5f744029d78a"), Type = TextBlockType.Text, Text = "Planes with this trait have gravitational forces much stronger than those on the Material Plane." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96b02ecc-15ad-40a5-946f-4b122fd4d94e"),
                SourceId = GamemasteryGuide.ID,
                Page = 252
            };
        }
    }
}
