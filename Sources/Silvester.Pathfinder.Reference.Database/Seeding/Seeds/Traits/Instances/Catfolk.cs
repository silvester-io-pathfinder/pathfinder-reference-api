using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Catfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("b2cdd51d-5562-4ec2-ba05-b039090c6d2c");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Catfolk",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3807b06e-8abb-4943-8c88-3cef0e68b114"), Type = TextBlockType.Text, Text = "A creature with this trait is a member of the catfolk ancestry. Catfolk are humanoids with feline features. An ability with this trait can be used or selected only by catfolk. An item with this trait is created and used by catfolk." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("101fc503-f380-4362-a400-675ac4a25439"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 266
            };
        }
    }
}
