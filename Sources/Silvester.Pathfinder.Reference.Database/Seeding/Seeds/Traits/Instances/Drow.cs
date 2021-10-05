using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Drow : Template
    {
        public static readonly Guid ID = Guid.Parse("3de012b2-0e72-481c-a006-205fec4644d6");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Drow",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1dba8f35-94cc-4f11-a703-3c8527975131"), Type = TextBlockType.Text, Text = "Subterranean kin of the elves, drow typically have darkvision and inborn magical abilities." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("597d09b8-cd2a-45fb-9da2-55846f6e9e89"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
