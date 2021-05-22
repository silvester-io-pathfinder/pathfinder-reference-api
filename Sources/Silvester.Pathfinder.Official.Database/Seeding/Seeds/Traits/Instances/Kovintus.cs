using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Kovintus : Template
    {
        public static readonly Guid ID = Guid.Parse("9a6ca06d-a1b7-40d5-a9aa-2e9f41aea663");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Kovintus",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("19c364b1-3bec-40f8-8090-e25cbc2d0bfc"), Type = TextBlockType.Text, Text = "Reclusive humanoids with an inborn talent for geomancy, kovintus have an intrinsic tie to nature and magic alike." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d5d48e7-966f-4bb7-81fb-815e3b50e1b7"),
                SourceId = Bestiary3.ID,
                Page = 309
            };
        }
    }
}
