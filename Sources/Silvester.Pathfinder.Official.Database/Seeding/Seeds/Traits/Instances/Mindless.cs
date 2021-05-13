using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Mindless : Template
    {
        public static readonly Guid ID = Guid.Parse("f28721b4-6e1a-4277-a7a5-8b9e0b086974");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Mindless",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0604ab80-183c-40a9-9142-7b63b6789318"), Type = TextBlockType.Text, Text = "A mindless creature has either programmed or rudimentary mental attributes. Most, if not all, of their mental ability modifiers are –5. They are immune to all mental effects." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("625d270c-67a0-47b9-9250-7d4987160f3c"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
