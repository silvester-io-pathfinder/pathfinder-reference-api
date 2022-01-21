using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Companion : Template
    {
        public static readonly Guid ID = Guid.Parse("e05ae250-111f-4e90-9332-3528b2f17d3a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Companion",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26a5ff62-c5d5-4a7a-8743-ecb37cd6bdda"), Type = TextBlockType.Text, Text = "An item with this trait can be worn by an animal companion or similar creature. A companion can have up to two items invested." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9df1675-51fb-40c5-9834-68d1e2b2818f"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
