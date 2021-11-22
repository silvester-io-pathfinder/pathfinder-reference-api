using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Scatter : Template
    {
        public static readonly Guid ID = Guid.Parse("abb2d7b6-5748-4546-9a9f-5a4814350bed");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Scatter",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("762608ca-1791-4bcd-924a-0dcd9d713621"), Type = TextBlockType.Text, Text = "This weapon fires a cluster of pellets in a wide spray. Scatter always has an area listed with it, indicating the radius of the spray. On a hit, the primary target of an attack with a scatter weapon takes the listed damage, and the target and all other creatures within the listed radius around it take 1 splash damage per weapon damage die." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12b5a909-9254-4be5-8ec4-3ec627908966"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 153
            };
        }
    }
}
