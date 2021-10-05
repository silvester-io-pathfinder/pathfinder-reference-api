using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Haunt : Template
    {
        public static readonly Guid ID = Guid.Parse("381a10e1-fed0-4758-ab43-cd74b3bf3362");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Haunt",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("382722a4-3802-4ede-a149-7312c9ddbf1e"), Type = TextBlockType.Text, Text = "A hazard with this trait is a spiritual echo, often of someone with a tragic death. Putting a haunt to rest often involves resolving the haunt’s unfinished business. A haunt that hasn’t been properly put to rest always returns after a time." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8080180-9bba-46c4-9770-2bcd58b6bcee"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
