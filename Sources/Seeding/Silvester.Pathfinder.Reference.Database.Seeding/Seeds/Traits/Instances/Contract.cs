using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Contract : Template
    {
        public static readonly Guid ID = Guid.Parse("b2c4b14f-bb2f-42a4-a4bc-6e0ef6df2ebe");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Contract",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bd7b5cc7-a5b6-436b-a8e9-d6b4ee6fc14f"), Type = TextBlockType.Text, Text = "A contract is a type of item that magically establishes an agreement between multiple parties and typically grants magical benefits." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8c26a87-1525-4444-b1c0-c69ecfa390e1"),
                SourceId = Legends.ID,
                Page = 10
            };
        }
    }
}
