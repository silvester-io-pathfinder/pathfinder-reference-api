using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Geniekin : Template
    {
        public static readonly Guid ID = Guid.Parse("49269c75-562f-4281-9302-f786e612c9df");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Geniekin",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2ad6657-2a93-4a23-8972-2fb35fcb2b0a"), Type = TextBlockType.Text, Text = "An umbrella term for planar scions descended from beings from the Elemental Planes. Geniekin craft and use these weapons." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f80fa9fc-31db-45c4-a4bf-b03ae56f4cba"),
                SourceId = AncestryGuide.ID,
                Page = 141
            };
        }
    }
}
