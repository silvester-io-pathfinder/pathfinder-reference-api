using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Cursed : Template
    {
        public static readonly Guid ID = Guid.Parse("838fb10d-67df-4271-a6d5-054c1eb54f63");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Cursed",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("38d54f45-56c0-4a77-901a-e6e3457cf761"), Type = TextBlockType.Text, Text = "An item with this trait is cursed to cause trouble for its owner. A curse isn’t detected when the item is identified, though a critical success reveals both the presence and exact nature of the curse. Cursed items can’t be discarded once they’ve been triggered or invested the first time. The item can be removed only if the curse is removed." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd5e42aa-8ade-4c6d-bb34-39c7e9fc9bcb"),
                SourceId = GamemasteryGuide.ID,
                Page = 251
            };
        }
    }
}
