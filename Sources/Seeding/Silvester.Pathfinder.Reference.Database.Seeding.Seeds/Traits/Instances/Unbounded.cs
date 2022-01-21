using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Unbounded : Template
    {
        public static readonly Guid ID = Guid.Parse("419ec619-744f-4a0b-b6b8-440fbeb0433a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Unbounded",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6b4140d-73ea-4c5d-b73b-2f0350b89e47"), Type = TextBlockType.Text, Text = "Planes with this trait loop back on themselves when a creature reaches the plane's edge." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5eeea428-b4a8-41a8-8eff-87d5cccfc85c"),
                SourceId = GamemasteryGuide.ID,
                Page = 254
            };
        }
    }
}
