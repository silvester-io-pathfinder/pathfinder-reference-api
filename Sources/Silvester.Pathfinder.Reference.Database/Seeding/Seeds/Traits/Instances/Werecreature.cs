using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Werecreature : Template
    {
        public static readonly Guid ID = Guid.Parse("a5bc07e1-023c-41a6-b6e6-9c37f5484ee3");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Werecreature",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4ca11ced-ae56-40b1-a742-9698ef6a0400"), Type = TextBlockType.Text, Text = "These shapechanging creatures either are naturally able to shift between animal, humanoid, and hybrid forms or are afflicted with a curse that forces them to shift involuntarily." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14442d48-7960-437c-93c2-a0144572a419"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
