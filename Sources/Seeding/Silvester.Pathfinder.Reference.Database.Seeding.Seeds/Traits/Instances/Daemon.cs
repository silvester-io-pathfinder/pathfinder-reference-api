using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Daemon : Template
    {
        public static readonly Guid ID = Guid.Parse("bbb6d3c8-d6c1-44bc-8c00-5fa83c063dcf");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Daemon",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6d1d35c-ce26-4c4a-9fa6-38c766f05a5b"), Type = TextBlockType.Text, Text = "A family of fiends spawned on the desolate plane of Abaddon, most daemons are neutral evil. They typically have darkvision and weakness to good damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d733b465-61e7-4b60-aefd-967bb8e1e975"),
                SourceId = Bestiary.ID,
                Page = 356
            };
        }
    }
}
