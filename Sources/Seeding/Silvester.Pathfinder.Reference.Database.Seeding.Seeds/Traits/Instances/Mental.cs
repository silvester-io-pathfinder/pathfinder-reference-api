using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Mental : Template
    {
        public static readonly Guid ID = Guid.Parse("d80c4c8b-646b-420c-a00d-cb15996520e2");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Mental",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("75bf6da2-1f43-4aa6-bb7a-2cedf3975b80"), Type = TextBlockType.Text, Text = "A mental effect can alter the target's mind. It has no effect on an object or a mindless creature." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c16f9a66-551b-48dc-b73a-e701397c8b45"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
