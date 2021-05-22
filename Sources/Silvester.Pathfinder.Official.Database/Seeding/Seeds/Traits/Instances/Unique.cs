using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Unique : Template
    {
        public static readonly Guid ID = Guid.Parse("995cdfe7-0a0b-4633-88d7-f88d499daeb3");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Unique",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("966bc322-dbcf-48a4-b5da-f04f540caf3d"), Type = TextBlockType.Text, Text = "A rules element with this trait is one-of-a-kind. The DC of Recall Knowledge checks related to creatures with this trait is increased by 10." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e22a9c2-20c6-47f6-b6b9-0d6ff4d1eeb1"),
                SourceId = CoreRulebook.ID,
                Page = 637
            };
        }
    }
}
