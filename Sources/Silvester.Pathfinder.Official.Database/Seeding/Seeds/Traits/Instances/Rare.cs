using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Rare : Template
    {
        public static readonly Guid ID = Guid.Parse("80770c53-f4d9-4895-a150-a57010382d13");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Rare",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d33c4be2-dbf2-4d34-a967-74d5f60a3b1b"), Type = TextBlockType.Text, Text = "This rarity indicates that a rules element is very difficult to find in the game world. A rare feat, spell, item or the like is available to players only if the GM decides to include it in the game, typically through discovery during play. Creatures with this trait are rare. They typically can’t be summoned. The DC of Recall Knowledge checks related to these creatures is increased by 5." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73bb9e3c-1e2c-4e11-91ad-5a79af370aed"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
