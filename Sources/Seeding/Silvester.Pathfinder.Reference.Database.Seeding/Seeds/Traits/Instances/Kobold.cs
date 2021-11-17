using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Kobold : Template
    {
        public static readonly Guid ID = Guid.Parse("e1b10ce6-01fa-4acd-bd2d-108944d770e1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Kobold",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7a4006a-fca0-4c1d-b09c-13c2b54d1bed"), Type = TextBlockType.Text, Text = "A creature with this trait is a member of the kobold ancestry. Kobolds are reptilian humanoids who are usually Small and typically have darkvision. An ability with this trait can be used or selected only by kobolds." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0df8cc46-6709-4e3d-9c7d-6b25ee00dcfc"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 268
            };
        }
    }
}
