using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Celestial : Template
    {
        public static readonly Guid ID = Guid.Parse("bbbb6740-63e4-427c-b352-d17bf0354b61");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Celestial",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c165d675-9c1c-44d5-a3f2-c3a8c9eb2ff6"), Type = TextBlockType.Text, Text = "Creatures that hail from or have a strong connection to the good-aligned planes are called celestials. Celestials can survive the basic environmental effects of planes in the Outer Sphere." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4abde54d-68bd-43b7-af60-da8166995a31"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
