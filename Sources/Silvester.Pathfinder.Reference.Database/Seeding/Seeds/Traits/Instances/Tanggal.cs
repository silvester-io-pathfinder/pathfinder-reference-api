using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Tanggal : Template
    {
        public static readonly Guid ID = Guid.Parse("a215a25c-f5d0-4f8a-881b-512d07a76ff6");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Tanggal",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("713c81d2-b104-4dff-89f8-1883cd923a87"), Type = TextBlockType.Text, Text = "This family of cannibalistic aberrations consists of various humanoid-shaped creatures that can separate their body into two pieces while hunting." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5ad373f-0cf1-4c98-a6d5-c8b2450c4bf0"),
                SourceId = Bestiary3.ID,
                Page = 310
            };
        }
    }
}
