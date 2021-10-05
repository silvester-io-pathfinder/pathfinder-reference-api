using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Focussed : Template
    {
        public static readonly Guid ID = Guid.Parse("66183f60-3966-425e-a2a1-e825c64c190a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Focussed",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d7a0720-08dc-4d10-864a-fe54927c2494"), Type = TextBlockType.Text, Text = "An item with this trait can give you an additional Focus Point. This focus point is separate from your focus pool and doesn’t count toward the cap on your focus pool. You can gain this benefit only if you have a focus pool, and there might be restrictions on how the point can be used. You can’t gain more than 1 Focus Point per day from focused items." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65e07a9d-d20b-4f8f-baab-ac1d40c356e0"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
