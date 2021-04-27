using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Aesir : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("d065e3df-631a-409a-b693-e23722ae0111");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Aesir",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f66780f-626a-4b4d-ba1d-3e56949bb2fa"), Type = TextBlockType.Text, Text = "Aesir are often-bellicose monitors of the chaotic planes, honing their skill in battle and preparing for a final confrontation at the end of the multiverse." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa5d986a-4b03-441f-858b-660f6a7f65a5"),
                SourceId = Bestiary3.ID,
                Page = 308
            };
        }
    }
}
