using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class SeaDevil : Template
    {
        public static readonly Guid ID = Guid.Parse("38f3b8d6-0bf4-462e-863f-698b9e114832");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Sea Devil",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b691a27-453d-411c-aa15-62ae6136221b"), Type = TextBlockType.Text, Text = "Evil ocean-dwelling humanoids, sea devils usually have darkvision and wavesense." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbbf83a8-7389-4b58-93f2-3976550889cc"),
                SourceId = Bestiary3.ID,
                Page = 347
            };
        }
    }
}
