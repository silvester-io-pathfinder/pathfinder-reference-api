using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Ghoran : Template
    {
        public static readonly Guid ID = Guid.Parse("1788ef80-8a1f-4bbb-98a8-b6a67d3e9f23");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Ghoran",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07405900-7dd8-4fa4-94c2-cc6a9e018a77"), Type = TextBlockType.Text, Text = "Ghorans are sapient plants grown in the shape of humanoids with floral faces." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5de747e2-8d4e-453f-8b02-055cf735aab6"),
                SourceId = Bestiary3.ID,
                Page = 309
            };
        }
    }
}
