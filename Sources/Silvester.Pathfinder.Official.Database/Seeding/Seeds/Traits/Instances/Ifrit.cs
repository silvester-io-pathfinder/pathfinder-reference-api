using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Ifrit : Template
    {
        public static readonly Guid ID = Guid.Parse("c3429aa8-1f8a-4b23-bf13-9f66691a651d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Ifrit",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79e7f806-f7e8-493b-b10c-97556c4412d3"), Type = TextBlockType.Text, Text = "Ifrits are planar scions descended from efreet." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a85e69ea-8e06-4ad5-aaff-0dccf244f7ca"),
                SourceId = Bestiary2.ID,
                Page = 309
            };
        }
    }
}
