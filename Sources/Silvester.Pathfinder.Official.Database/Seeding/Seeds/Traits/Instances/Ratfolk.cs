using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Ratfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("b0d84536-c184-47d5-b28a-5c71d5daa2e5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Ratfolk",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("602e4bcb-2185-43fe-b90b-82a321691c57"), Type = TextBlockType.Text, Text = "A creature with this trait is a member of the ratfolk ancestry. Ratfolk are humanoids who resemble rats. An ability with this trait can be used or selected only by ratfolk." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5f0777c-d143-4921-846f-282c25a10953"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 269
            };
        }
    }
}
