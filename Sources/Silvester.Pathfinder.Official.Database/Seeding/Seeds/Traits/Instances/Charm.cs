using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Charm : Template
    {
        public static readonly Guid ID = Guid.Parse("b4b7b5e5-f4c0-40d3-89b2-500840877953");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Charm",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("56191621-ceaf-4518-95e9-d828d60fb3c4"), Type = TextBlockType.Text, Text = "There was not explicit description for this trait." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("571c97de-e315-4469-b43b-90cf85800b79"),
                SourceId = Bestiary.ID,
                Page = 77
            };
        }
    }
}
