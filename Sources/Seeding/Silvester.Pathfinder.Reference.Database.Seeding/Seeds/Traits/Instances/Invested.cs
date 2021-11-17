using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Invested : Template
    {
        public static readonly Guid ID = Guid.Parse("acf154b6-1967-4305-a859-4bcd362a2cd4");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Invested",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14b3b19f-8863-4bc6-9da8-15cd92097781"), Type = TextBlockType.Text, Text = "A character can wear only 10 magical items that have the invested trait. None of the magical effects of the item apply if the character hasn’t invested it, nor can it be activated, though the character still gains any normal benefits from wearing the physical item (like a hat keeping rain off their head)." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05045ea8-3dd7-44f6-852f-e8e950814b13"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
