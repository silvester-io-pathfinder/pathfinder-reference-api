using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Android : Template
    {
        public static readonly Guid ID = Guid.Parse("276de126-8331-48aa-9318-d40d10977a95");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Android",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f2839aa1-b6b7-4534-8450-259258aa4372"), Type = TextBlockType.Text, Text = "A synthetic humanoid ancestry created by artificial means. Most common in Numeria." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e9e1d6d-029c-4772-ad0e-cb2a009a2599"),
                SourceId = AncestryGuide.ID,
                Page = 140
            };
        }
    }
}
