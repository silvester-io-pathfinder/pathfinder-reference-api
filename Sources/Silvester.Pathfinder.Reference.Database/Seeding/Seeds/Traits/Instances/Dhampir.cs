using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Dhampir : Template
    {
        public static readonly Guid ID = Guid.Parse("071b12f3-135e-4d4f-a80e-705d41f4f051");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Dhampir",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("57b55778-167e-45ac-8549-75862352898f"), Type = TextBlockType.Text, Text = "A creature with this trait has the dhampir versatile heritage. These humanoids are the immortal offspring of vampires and members of other ancestries." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56513009-334e-44a7-a535-1cfc44b78689"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 267
            };
        }
    }
}
