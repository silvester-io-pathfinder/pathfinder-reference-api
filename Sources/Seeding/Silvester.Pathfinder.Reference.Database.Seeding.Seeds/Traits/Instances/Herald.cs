using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Herald : Template
    {
        public static readonly Guid ID = Guid.Parse("48631050-4839-4898-8a0f-2a053135abf0");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Herald",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("470ca809-e56b-4aa1-a690-61cf04ab424a"), Type = TextBlockType.Text, Text = "Nearly all deities have a specific representative known as a herald; heralds are as diverse in their appearances and abilities as the gods themselves. A creature with the herald type is always unique." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38c19251-b98e-4e58-a0fd-e51d6996adb6"),
                SourceId = Pathfinder160.ID,
                Page = 85
            };
        }
    }
}
