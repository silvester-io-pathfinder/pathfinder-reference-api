using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Kami : Template
    {
        public static readonly Guid ID = Guid.Parse("3cdaa83c-681d-47d1-9a98-d0f15b6b0d61");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Kami",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4b1de9f5-3c29-4842-a79b-37568f5ff76c"), Type = TextBlockType.Text, Text = "Kami are spirits of the Material Plane that bond with a specific object or place." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ace13135-c51a-4585-9014-85c6412f10b3"),
                SourceId = Bestiary3.ID,
                Page = 309
            };
        }
    }
}
