using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Repeating : Template
    {
        public static readonly Guid ID = Guid.Parse("a07f371f-a95b-4cbb-85d3-094c8fe58fba");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Repeating",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("636855f5-5e2c-484a-be48-35c372e55ef1"), Type = TextBlockType.Text, Text = "A repeating weapon is typically a type of crossbow that has a shorter reload time. These weapons can't be loaded with individual bolts like other crossbows; instead, they require a magazine of specialized ammunition to be loaded into a special slot. Once that magazine is in place, the ammunition is automatically loaded each time the weapon is cocked to fire, reducing its reload to the value in its reload entry (typically 0). When the ammunition runs out, a new magazine must be loaded, which requires a free hand and 3 Interact actions (to remove the old magazine, retrieve the new magazine, and slot the new magazine in place). These actions don't need to be consecutive." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d177673-4141-4e1a-9c79-4daf85fc9b2b"),
                SourceId = Pathfinder165.ID,
                Page = 73
            };
        }
    }
}
