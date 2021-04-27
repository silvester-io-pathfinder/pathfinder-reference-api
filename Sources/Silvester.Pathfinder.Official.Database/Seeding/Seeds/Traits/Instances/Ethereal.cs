using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Ethereal : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("c5df9651-d3e6-443f-8811-dbdc43ccb52c");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Ethereal",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8cf5e32f-e6eb-429d-b4bf-db9abf49028b"), Type = TextBlockType.Text, Text = "Ethereal creatures are natives of the Ethereal Plane. They can survive the basic environmental effects of the Ethereal Plane." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c9c4f11-1211-4a30-ab3e-a02fe9fc2bc9"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
