using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Oracle : Template
    {
        public static readonly Guid ID = Guid.Parse("67c1da65-5ed2-4d0b-87e7-dbebb50bc31a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Oracle",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8800b2d6-9b87-405b-8ca4-fa9f1a0885a6"), Type = TextBlockType.Text, Text = "This trait indicates abilities from the oracle class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2497639-3494-4b08-8e8c-692914633fe6"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 269
            };
        }
    }
}
