using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Healing : Template
    {
        public static readonly Guid ID = Guid.Parse("6adbe888-3fd9-4137-afc8-af4bd6f674a9");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Healing",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("be9409c2-a5b4-456c-8d32-f2d5628c61bc"), Type = TextBlockType.Text, Text = "A healing effect restores a creature's body, typically by restoring Hit Points, but sometimes by removing diseases or other debilitating effects." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61e1b362-6aec-49a9-a0ff-a511e9a8d869"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
