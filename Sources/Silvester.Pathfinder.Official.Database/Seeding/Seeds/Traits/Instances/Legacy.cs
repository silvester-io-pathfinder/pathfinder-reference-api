using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Legacy : Template
    {
        public static readonly Guid ID = Guid.Parse("9e216e7c-93cf-4daa-b628-f97109c3564a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Legacy",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("189c2680-9a03-4a89-9225-525e96e40ff5"), Type = TextBlockType.Text, Text = "Once you’ve played through the listed Adventure Path, these rare backgrounds can become available in your future campaigns after the events of this Adventure Path." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd2a6a0d-6f35-4c0a-8c73-cb9581f9a19c"),
                SourceId = Pathfinder150.ID,
                Page = 73
            };
        }
    }
}
