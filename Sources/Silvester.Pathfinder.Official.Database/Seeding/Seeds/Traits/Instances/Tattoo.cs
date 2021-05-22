using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Tattoo : Template
    {
        public static readonly Guid ID = Guid.Parse("ff6709fa-7a60-44c2-8aaf-83d8726fa77c");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Tattoo",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a8b0a1ef-c1c5-45d8-89d2-f127454592c9"), Type = TextBlockType.Text, Text = "A tattoo is a type of item that is drawn or cut into a creature’s skin and usually takes the form of images or symbols." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eeb1fbef-58c8-4fd0-8c52-98d106c8f812"),
                SourceId = WorldGuide.ID,
                Page = 134
            };
        }
    }
}
