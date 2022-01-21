using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Finite : Template
    {
        public static readonly Guid ID = Guid.Parse("ae3ffdd3-8624-43b8-aaa2-d1237b0ee59c");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Finite",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("896cfd3f-16bd-4a90-89bf-e4198cd88f2f"), Type = TextBlockType.Text, Text = "Planes with this trait consist of a limited amount of space." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19b9adc5-c44b-40c3-84ea-23bd428457fe"),
                SourceId = GamemasteryGuide.ID,
                Page = 251
            };
        }
    }
}
