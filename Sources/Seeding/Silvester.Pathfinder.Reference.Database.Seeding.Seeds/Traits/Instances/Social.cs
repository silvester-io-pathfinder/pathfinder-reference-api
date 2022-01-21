using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Social : Template
    {
        public static readonly Guid ID = Guid.Parse("1bfb1a5e-82ff-4b76-a224-eb257ff32753");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Social",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0b9166f-9aae-4f3d-b521-2bf2e52b01a7"), Type = TextBlockType.Text, Text = "Actions and abilities with the social trait can be used only while a vigilante is in their social identity." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c47ee68-275e-49b6-838e-4c40f6050a00"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 270
            };
        }
    }
}
