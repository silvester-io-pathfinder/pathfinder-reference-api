using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Azarketi : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("3e6590db-5cd3-4707-8ca7-3959859f81d4");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Azarketi",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6af38d25-4fdb-4c6a-bde3-106fb3c7ae52"), Type = TextBlockType.Text, Text = "Amphibious humanoids who live among the seas of the Inner Sea region, said to have descended from the people of Azlant. Sometimes known as gillmen or Low Azlanti." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32121b25-e46d-44a4-aa63-d9d30f80d7ed"),
                SourceId = AncestryGuide.ID,
                Page = 140
            };
        }
    }
}
