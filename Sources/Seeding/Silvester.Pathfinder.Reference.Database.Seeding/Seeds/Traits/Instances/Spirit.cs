using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Spirit : Template
    {
        public static readonly Guid ID = Guid.Parse("a7bb677c-3efa-4e27-9c61-01e34e08cab8");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Spirit",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c51d9ced-d892-4218-b477-726b8ceb67fe"), Type = TextBlockType.Text, Text = "Spirits are ephemeral creatures defined by their spiritual self and often lacking a physical form." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e3deb75-de15-439d-bee0-1b11d3d31790"),
                SourceId = CoreRulebook.ID,
                Page = 636
            };
        }
    }
}
