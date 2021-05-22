using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Gnoll : Template
    {
        public static readonly Guid ID = Guid.Parse("e3224ed6-b3f5-43e1-ac7d-36828dad030b");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Gnoll",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d187e51-d275-4cdd-9848-af8411bfa9e2"), Type = TextBlockType.Text, Text = "Gnolls are humanoids that resemble hyenas." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9004e61f-035c-42c2-bffd-995fdd516e04"),
                SourceId = Bestiary.ID,
                Page = 346
            };
        }
    }
}
