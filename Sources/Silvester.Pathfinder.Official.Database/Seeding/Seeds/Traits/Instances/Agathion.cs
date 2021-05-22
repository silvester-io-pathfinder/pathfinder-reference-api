using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Agathion : Template
    {
        public static readonly Guid ID = Guid.Parse("7c5ad646-6245-446e-83ff-cde9a47c7254");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Agathion",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0e29f2e5-3513-423d-835b-065c6ce7b08f"), Type = TextBlockType.Text, Text = "This family of animal-featured celestials is native to the plane of Nirvana. Most agathions are neutral good, have darkvision, and have a weakness to evil damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59c7e087-3a1d-4b74-ae4b-37a538562ec5"),
                SourceId = Bestiary3.ID,
                Page = 308
            };
        }
    }
}
