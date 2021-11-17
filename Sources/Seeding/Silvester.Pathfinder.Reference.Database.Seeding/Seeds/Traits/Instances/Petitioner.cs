using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Petitioner : Template
    {
        public static readonly Guid ID = Guid.Parse("788f42f9-1e86-4f08-9e12-3e3eec9ca3b5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Petitioner",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("696e4e89-6190-4d11-93d4-f2d7c97bb5b7"), Type = TextBlockType.Text, Text = "Petitioners are mortal souls who have been judged and then transformed into creatures native to other planes. Petitioners can survive the basic environmental effects of their home plane." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7bfebe02-dd03-4d7c-92d6-428d3866b07d"),
                SourceId = Bestiary2.ID,
                Page = 309
            };
        }
    }
}
