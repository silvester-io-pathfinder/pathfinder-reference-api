using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Sonic : Template
    {
        public static readonly Guid ID = Guid.Parse("0dddb0a4-0037-47c7-b2bc-6479caa43694");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Sonic",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f381f51e-3b04-466b-a5dd-9c917575bec9"), Type = TextBlockType.Text, Text = "An effect with the sonic trait functions only if it makes sound, meaning it has no effect in an area of silence or in a vacuum. This is different from an auditory spell, which is effective only if the target can hear it. A sonic effect might deal sonic damage. A creature with this trait has a magical connection to powerful sound." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34fe8976-b7ea-4dad-82cf-76dd56cf0753"),
                SourceId = CoreRulebook.ID,
                Page = 636
            };
        }
    }
}
