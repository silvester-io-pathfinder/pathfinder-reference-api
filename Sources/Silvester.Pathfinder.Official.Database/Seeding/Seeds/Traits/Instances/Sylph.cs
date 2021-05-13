using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Sylph : Template
    {
        public static readonly Guid ID = Guid.Parse("1be9b1ec-9a82-42aa-8e8e-3b7f80c886fa");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Sylph",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc4b1c8f-9163-4bb3-a631-cc1c96f3978e"), Type = TextBlockType.Text, Text = "Sylphs are planar scions descended from djinn." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe578ebd-6637-448b-97e2-38e2f92acce9"),
                SourceId = Bestiary2.ID,
                Page = 310
            };
        }
    }
}
