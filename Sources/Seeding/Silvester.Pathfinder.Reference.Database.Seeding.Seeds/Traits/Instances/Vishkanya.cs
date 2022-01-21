using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Vishkanya : Template
    {
        public static readonly Guid ID = Guid.Parse("42f3721a-f751-417f-a0f8-c563f7d74f08");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Vishkanya",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5fb9867-40c1-412a-ae45-afa939756d5f"), Type = TextBlockType.Text, Text = "These faintly ophidian humanoids have venomous blood and saliva." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58601d2a-78d1-493c-b25d-595cfa66712f"),
                SourceId = Bestiary3.ID,
                Page = 310
            };
        }
    }
}
