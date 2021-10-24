using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Instinct : Template
    {
        public static readonly Guid ID = Guid.Parse("583136ca-8e2e-47bc-b9c4-d6f6286b5aea");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Instinct",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a002415-2454-4a48-9c48-d486776f289a"), Type = TextBlockType.Text, Text = "Instinct abilities require a specific instinct; you lose access if you perform acts anathema to your instinct." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac2f00ac-4ec9-4f5e-9b12-59b1f20cea8b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 638
            };
        }
    }
}
