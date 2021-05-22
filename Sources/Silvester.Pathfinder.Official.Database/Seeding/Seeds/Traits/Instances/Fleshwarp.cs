using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Fleshwarp : Template
    {
        public static readonly Guid ID = Guid.Parse("25b12587-6109-4b67-85bc-aa12e0a0f86b");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Fleshwarp",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("879a2203-f3b1-414f-9371-3c1c566a6d67"), Type = TextBlockType.Text, Text = "A humanoid transformed so completely by outside forces that they are now a unique ancestry" };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f2b4f9f-1062-410b-b2a4-a127750b0465"),
                SourceId = AncestryGuide.ID,
                Page = 141
            };
        }
    }
}
