using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Artifact : Template
    {
        public static readonly Guid ID = Guid.Parse("8b3e67ad-f782-49ec-941f-ba99e83811fd");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Artifact",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d050f16d-16d9-47d0-b2e1-60b71b75b33f"), Type = TextBlockType.Text, Text = "Items with this trait are artifacts. These magic items can’t be crafted by normal means, and they can’t be damaged by normal means. Artifacts are always rare or unique." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("572e4f63-6528-4717-a7e3-c23624aa54fb"),
                SourceId = GamemasteryGuide.ID,
                Page = 250
            };
        }
    }
}
