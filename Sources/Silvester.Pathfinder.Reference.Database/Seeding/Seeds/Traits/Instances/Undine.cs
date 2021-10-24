using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Undine : Template
    {
        public static readonly Guid ID = Guid.Parse("22583447-bd14-445d-8e71-fbfae42f8bc0");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Undine",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d622c655-5186-43a9-a4e3-16c6837793f3"), Type = TextBlockType.Text, Text = "Undines are planar scions descended from marids." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62dc18f6-c53a-4397-960f-64bff7b97ebc"),
                SourceId = Bestiary2.ID,
                Page = 310
            };
        }
    }
}
