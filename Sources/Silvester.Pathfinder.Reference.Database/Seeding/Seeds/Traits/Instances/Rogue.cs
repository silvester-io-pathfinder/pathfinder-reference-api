using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Rogue : Template
    {
        public static readonly Guid ID = Guid.Parse("008386f8-545f-4ced-a04e-b819a45c3cbb");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Rogue",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a286907c-e251-4895-b7d6-c747dba39cd9"), Type = TextBlockType.Text, Text = "This indicates abilities from the rogue class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15cd9b46-b31a-4763-9957-450d154f07d4"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
