using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Clockwork : Template
    {
        public static readonly Guid ID = Guid.Parse("2d5e025a-19de-4f4d-bd58-9bcb29049c93");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Clockwork",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4a4061bc-9430-43e3-87c9-eb59cd336167"), Type = TextBlockType.Text, Text = "Clockworks are intricate, complex constructs that can be programmed to perform specific functions. A clockwork creature must be wound regularly to function." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f443e0f7-ba01-4eb1-a9a2-c93ec4e92998"),
                SourceId = Bestiary3.ID,
                Page = 308
            };
        }
    }
}
