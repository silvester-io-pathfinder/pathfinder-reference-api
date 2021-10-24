using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Consecration : Template
    {
        public static readonly Guid ID = Guid.Parse("965d15d5-bc6d-4d12-99ec-baf53a276546");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Consecration",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad06ff83-d7a8-4e8a-98c2-da3f5b225141"), Type = TextBlockType.Text, Text = "A consecration spell enhances an area for an extended period of time. A given area can have only a single consecration effect at a time. The new effect attempts to counteract any existing one in areas of overlap." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c30d388-90d7-4ebc-a754-4059ef5d1f1c"),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
