using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Telepathy : Template
    {
        public static readonly Guid ID = Guid.Parse("e29b02f2-8555-474a-a501-ecbfa4a3dbdc");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Telepathy",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("74aaccc8-d0dd-4c85-ae5d-c370d9b9ce54"), Type = TextBlockType.Text, Text = "There was not explicit description for this trait." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a556e4c-74af-43b5-831f-3b4208dafc1c"),
                SourceId = Bestiary.ID,
                Page = 287
            };
        }
    }
}
