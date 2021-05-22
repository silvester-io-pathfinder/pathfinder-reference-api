using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Abberation : Template
    {
        public static readonly Guid ID = Guid.Parse("ee334634-256b-4334-b2c9-b0024939c185");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Abberation",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a5af7043-9daf-4782-b413-e2f3ffd79b41"), Type = TextBlockType.Text, Text = "Aberrations are creatures from beyond the planes or corruptions of the natural order." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a1b9f542-7096-4298-81cc-9dd138f755d4"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
