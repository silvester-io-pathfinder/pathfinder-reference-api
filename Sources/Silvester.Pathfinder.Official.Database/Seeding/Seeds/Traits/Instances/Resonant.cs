using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Resonant : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("f6438a46-50a0-41ce-b415-0efd40fe05a7");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Resonant",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2d8fdc2-7550-483a-8d79-dc5a07666d34"), Type = TextBlockType.Text, Text = "This weapon can channel energy damage. You gain the Conduct Energy free action while wielding a resonant weapon." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("edd06a79-2767-46d5-8360-58ff246fa296"),
                SourceId = AncestryGuide.ID,
                Page = 139
            };
        }
    }
}
