using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Inventor : Template
    {
        public static readonly Guid ID = Guid.Parse("a37a1eea-99ae-47dd-97a5-b07d54fb8f6d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Inventor",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bf895d17-4bd3-49b9-b820-b360ac98cd3c"), Type = TextBlockType.Text, Text = "This indicates abilities from the inventor class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9463ac7-4754-43a3-a91a-21ce93a75876"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 233
            };
        }
    }
}
