using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Strix : Template
    {
        public static readonly Guid ID = Guid.Parse("eb20e60f-fe7e-4c0e-a356-5d1f485dfdca");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Strix",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d05fd0a-3a7b-4f51-bce1-4eab5420ca68"), Type = TextBlockType.Text, Text = "Winged humanoids, most of whom live in and around Cheliax." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b8040ea-daf9-4b3c-889f-710c8d744668"),
                SourceId = AncestryGuide.ID,
                Page = 142
            };
        }
    }
}
