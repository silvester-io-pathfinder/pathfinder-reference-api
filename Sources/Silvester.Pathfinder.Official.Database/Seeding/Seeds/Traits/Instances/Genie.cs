using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Genie : Template
    {
        public static readonly Guid ID = Guid.Parse("eac6a94d-c0df-40e5-b493-68b3cff59c04");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Genie",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("52f4a7c2-a491-4a71-9470-585b0a049f5c"), Type = TextBlockType.Text, Text = "The diverse families of genies hold positions of prominence on the Elemental Planes. They have powerful magical abilities." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b28da89f-5511-451a-99c8-7a9813bb32c0"),
                SourceId = Bestiary.ID,
                Page = 346
            };
        }
    }
}
