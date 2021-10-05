using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Sack : Template
    {
        public static readonly Guid ID = Guid.Parse("f2913e46-d954-49e8-82b2-76d1c13e8172");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Sack",
                Hands = "1",
                Price = 1,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bba92ca0-01d2-4111-a6bc-b3ec6103db7f"), Type = TextBlockType.Text, Text = "A sack can hold up to 8 Bulk worth of items. A sack containing 2 Bulk or less can be worn on the body, usually tucked into a belt. You can carry a sack with one hand, but must use two hands to transfer items in and out." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eded4e9c-8827-4b66-ade0-acd2bf1d4a0a"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
