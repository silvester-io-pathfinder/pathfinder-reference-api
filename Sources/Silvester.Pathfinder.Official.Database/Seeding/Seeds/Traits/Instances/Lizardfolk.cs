using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Lizardfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("84523211-cdc1-4622-bef5-fe6e0036e76b");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Lizardfolk",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e00fc8d8-fb3b-4a69-9510-dcdecf902d10"), Type = TextBlockType.Text, Text = "These reptilian humanoids, also known as iruxi, are extremely adaptable and patient." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f908b0d-78f6-4068-b4f0-dd0a2d84fae1"),
                SourceId = CharacterGuide.ID,
                Page = 133
            };
        }
    }
}
