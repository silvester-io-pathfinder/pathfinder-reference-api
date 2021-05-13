using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Immeasurable : Template
    {
        public static readonly Guid ID = Guid.Parse("0eb633c2-3994-4583-9731-40f8914dc40e");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Immeasurable",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc4cf05b-cc78-44df-a851-276dcf04aa6a"), Type = TextBlockType.Text, Text = "Planes with this trait are immeasurably large, perhaps infinite." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f9d7404-18fb-4cfd-8953-fc51f8af4579"),
                SourceId = GamemasteryGuide.ID,
                Page = 252
            };
        }
    }
}
