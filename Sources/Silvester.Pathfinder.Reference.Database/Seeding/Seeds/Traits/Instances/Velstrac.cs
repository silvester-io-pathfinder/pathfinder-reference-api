using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Velstrac : Template
    {
        public static readonly Guid ID = Guid.Parse("9b0d55c4-92f6-45da-beaf-bd3dce46f96d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Velstrac",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5cb6d8b-029b-4344-b202-edd18ec95596"), Type = TextBlockType.Text, Text = "A family of fiends from the Shadow Plane that are associated with pain and agony. All velstracs possess some form of disturbing gaze." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb8c63ac-4cad-4b83-8594-3b672c838409"),
                SourceId = Pathfinder147.ID,
                Page = 82
            };
        }
    }
}
