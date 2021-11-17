using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Arcane : Template
    {
        public static readonly Guid ID = Guid.Parse("fbe4f84d-576e-4d90-87a7-c6f96c213367");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Arcane",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e1a68b1b-3382-4f19-b87b-16cda6c95c9d"), Type = TextBlockType.Text, Text = "This magic comes from the arcane tradition, which is built on logic and rationality. Anything with this trait is magical." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef3e6ec3-3b03-465f-9508-8d6bb0583469"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
