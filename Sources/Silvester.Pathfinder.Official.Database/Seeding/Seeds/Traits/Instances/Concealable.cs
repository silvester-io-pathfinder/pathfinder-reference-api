using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Concealable : Template
    {
        public static readonly Guid ID = Guid.Parse("5cec7ab0-da0f-42d0-89d8-c3d3109e70eb");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Concealable",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("28b2b904-a864-4ea4-ab2e-ba40d9255ee3"), Type = TextBlockType.Text, Text = "This weapon is designed to be inconspicuous or easily concealed. You gain a +2 circumstance bonus to Stealth checks and DCs to hide or conceal a weapon with this trait." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81511bbc-21fd-45f5-8cf6-7d376620192c"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 266
            };
        }
    }
}
