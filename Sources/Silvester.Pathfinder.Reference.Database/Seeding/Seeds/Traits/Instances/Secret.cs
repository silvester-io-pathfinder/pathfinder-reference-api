using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Secret : Template
    {
        public static readonly Guid ID = Guid.Parse("a0a87999-5769-4838-ae13-d9e0c8afbed4");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Secret",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0033865a-cec6-4770-a63d-96d92fdb6163"), Type = TextBlockType.Text, Text = "The GM rolls the check for this ability in secret." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3dd25544-7718-4fdb-b7e8-c2affcdf4014"),
                SourceId = CoreRulebook.ID,
                Page = 636
            };
        }
    }
}
