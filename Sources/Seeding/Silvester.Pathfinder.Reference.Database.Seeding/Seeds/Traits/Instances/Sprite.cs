using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Sprite : Template
    {
        public static readonly Guid ID = Guid.Parse("9763c00f-109f-4065-ab42-ecb5857d0ccd");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Sprite",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("747aabb1-4867-4399-9b01-dd5dea2c382a"), Type = TextBlockType.Text, Text = "A family of diminutive winged fey with a strong connection to primal magic." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b56b7716-1f8c-4fb5-b2b3-a175c32b29cb"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
