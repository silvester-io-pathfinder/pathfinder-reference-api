using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Witch : Template
    {
        public static readonly Guid ID = Guid.Parse("c3f17377-4717-4be2-85cd-e6a82b391d64");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Witch",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d014cf6-48b8-4827-b54b-d62616701aee"), Type = TextBlockType.Text, Text = "This trait indicates abilities from the witch class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40d60a14-fd4f-4411-8f03-2742c73eda22"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 271
            };
        }
    }
}
