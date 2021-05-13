using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Teleportation : Template
    {
        public static readonly Guid ID = Guid.Parse("693f3b70-37e7-4da0-8da7-4d865c82add2");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Teleportation",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab6cff92-5bd6-49d5-a890-5c9dcb1efabc"), Type = TextBlockType.Text, Text = "Teleportation effects allow you to instantaneously move from one point in space to another. Teleportation does not usually trigger reactions based on movement." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db7fe801-bea9-4036-a0cb-0c23480e7960"),
                SourceId = CoreRulebook.ID,
                Page = 637
            };
        }
    }
}
