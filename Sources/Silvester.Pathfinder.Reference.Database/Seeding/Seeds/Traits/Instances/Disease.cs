using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Disease : Template
    {
        public static readonly Guid ID = Guid.Parse("413975b5-0faa-4762-a8fb-935b28b79301");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Disease",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("389b2836-82f5-4611-bf73-5a4e212b445c"), Type = TextBlockType.Text, Text = "An effect with this trait applies one or more diseases. A disease is typically an affliction." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47b3ebfa-8c18-4054-a738-bc94a77a49b4"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
