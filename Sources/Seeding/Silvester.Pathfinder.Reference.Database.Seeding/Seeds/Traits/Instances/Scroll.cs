using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Scroll : Template
    {
        public static readonly Guid ID = Guid.Parse("ab024244-3eea-4f3a-b38a-848fd67e130a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Scroll",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a9058ce1-2ecd-4d1c-a9a9-b0aadbfe7545"), Type = TextBlockType.Text, Text = "A scroll contains a single spell you can cast without a spell slot." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b6bc0b5f-8939-438c-bf91-1d695a72c3f1"),
                SourceId = CoreRulebook.ID,
                Page = 636
            };
        }
    }
}
