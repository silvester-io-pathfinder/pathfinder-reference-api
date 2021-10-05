using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Titan : Template
    {
        public static readonly Guid ID = Guid.Parse("449f835b-f5db-48d4-854a-cab7368cb20a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Titan",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9cde9411-ddf6-4b63-ae95-a4cfaca79b6e"), Type = TextBlockType.Text, Text = "Titans are enormous, primordial creatures of neargodlike power who predate the mortal races." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6488d1ad-a015-44c9-b226-9685154107e2"),
                SourceId = Pathfinder156.ID,
                Page = 82
            };
        }
    }
}
