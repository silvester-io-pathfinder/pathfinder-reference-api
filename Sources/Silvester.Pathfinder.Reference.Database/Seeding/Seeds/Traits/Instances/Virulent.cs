using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Virulent : Template
    {
        public static readonly Guid ID = Guid.Parse("24dc1d6b-75c3-4255-8847-f6dc04a7ce96");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Virulent",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("358d4b3a-92c1-4c8c-9930-5bb3d09d2b72"), Type = TextBlockType.Text, Text = "Afflictions with the virulent trait are harder to remove. You must succeed at two consecutive saves to reduce a virulent affliction’s stage by 1. A critical success reduces a virulent affliction’s stage by only 1 instead of by 2." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4384c23-d5c5-4eff-a4d5-08fdf5048414"),
                SourceId = CoreRulebook.ID,
                Page = 638
            };
        }
    }
}
