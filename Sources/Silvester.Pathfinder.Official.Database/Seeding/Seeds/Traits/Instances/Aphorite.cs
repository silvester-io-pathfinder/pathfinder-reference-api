using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Aphorite : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("2903ddd8-22a3-4dc0-842e-e484d94ee53a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Aphorite",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("492d9b1b-6a3d-496f-88ca-225e3050897f"), Type = TextBlockType.Text, Text = "A type of planar scion descended from a being from Axis, the Plane of Law." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ec13310-eb89-4e86-97ef-2a665ab4409e"),
                SourceId = AncestryGuide.ID,
                Page = 140
            };
        }
    }
}
