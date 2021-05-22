using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Soulbound : Template
    {
        public static readonly Guid ID = Guid.Parse("341d2366-5440-4f9a-b265-23f035af27a5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Soulbound",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dc4af3d6-9cda-4969-b373-eecce379ef0c"), Type = TextBlockType.Text, Text = "These constructs are mentally augmented by a fragment of a once-living creature’s soul." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7994ca86-2787-4515-950d-7fdda3d088d7"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
