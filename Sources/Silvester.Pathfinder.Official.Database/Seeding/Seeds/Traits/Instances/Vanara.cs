using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Vanara : Template
    {
        public static readonly Guid ID = Guid.Parse("9ddf2c48-1a7f-4877-8957-deaaec7d485b");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Vanara",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8e90af5f-c83c-441a-8976-7cbb8d99f364"), Type = TextBlockType.Text, Text = "Vanaras are monkeylike humanoids who share a devotion to monastic training." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b64c8420-70c9-471c-8006-ad56c3747ff6"),
                SourceId = Bestiary3.ID,
                Page = 310
            };
        }
    }
}
