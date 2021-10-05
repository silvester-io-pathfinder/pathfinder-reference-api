using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Reckless : Template
    {
        public static readonly Guid ID = Guid.Parse("4f39e05a-0fb0-4399-9987-c6b1cd4ade55");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Reckless",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e7fdcd7-36ec-4583-a716-379057a2139b"), Type = TextBlockType.Text, Text = "Actions with the reckless trait run the risk of the pilot losing control of a vehicle. When performing a reckless action, the pilot must first attempt an appropriate piloting check to keep control of the vehicle." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afbbfe5d-bb15-41b6-b67d-c60385e07a29"),
                SourceId = GamemasteryGuide.ID,
                Page = 254
            };
        }
    }
}
