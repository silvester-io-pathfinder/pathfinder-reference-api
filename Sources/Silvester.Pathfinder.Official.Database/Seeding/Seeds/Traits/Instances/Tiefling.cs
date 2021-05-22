using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Tiefling : Template
    {
        public static readonly Guid ID = Guid.Parse("0d84cd27-92f4-4b56-90d6-b83aadb1b688");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Tiefling",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d13c4280-4caa-449b-a880-1fcd9a4ca9ed"), Type = TextBlockType.Text, Text = "A creature with this trait has the tiefling versatile heritage. Tieflings are planar scions descended from fiends. An ability with this trait can be used or selected only by tieflings." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ac41cd5-d6b6-4737-8806-152246cb3454"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 270
            };
        }
    }
}
