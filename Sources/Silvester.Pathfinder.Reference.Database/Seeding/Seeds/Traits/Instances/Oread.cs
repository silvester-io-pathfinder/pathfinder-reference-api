using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class AdditOreadive2 : Template
    {
        public static readonly Guid ID = Guid.Parse("03b5099e-4b12-408d-a2d7-c8b3ca692291");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Oread",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0e25df3-323c-4f1d-adcd-3fda410f765a"), Type = TextBlockType.Text, Text = "Oreads are planar scions descended from shaitans." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d93ccd35-3d1e-4ecc-9293-8bcd3a3b2897"),
                SourceId = Bestiary2.ID,
                Page = 309
            };
        }
    }
}
