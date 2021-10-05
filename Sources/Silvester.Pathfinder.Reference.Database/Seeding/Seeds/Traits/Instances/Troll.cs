using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Troll : Template
    {
        public static readonly Guid ID = Guid.Parse("30cbee08-6c59-4b86-9160-21c97e38148d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Troll",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("83789e69-acd9-4d8a-bfbf-ed14fc95897a"), Type = TextBlockType.Text, Text = "Trolls are giant, brutish creatures and are well known for their ability to regenerate." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5b75d08-2537-4555-a647-5d05a1b2223c"),
                SourceId = Bestiary3.ID,
                Page = 347
            };
        }
    }
}
