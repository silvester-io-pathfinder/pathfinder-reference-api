using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Revelation : Template
    {
        public static readonly Guid ID = Guid.Parse("162b1085-1426-4953-8f5a-b11ff6432163");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Revelation",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f8f2c3bc-1d75-4e2f-a5df-78d6d73f5085"), Type = TextBlockType.Text, Text = "Effects with this trait see things as they truly are." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37dd8a63-be1b-4e2b-912d-2f3be9b05c50"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
