using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class MerchantsScale : Template
    {
        public static readonly Guid ID = Guid.Parse("7befcd2d-6e94-4956-af49-2d7206a44d13");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Merchant's Scale",
                Hands = "2",
                Price = 20,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("92f5b23c-e923-4cf9-ac34-50d89ee149be"), Type = TextBlockType.Text, Text = "A merchant's scale grants a +2 circumstance bonus on Appraise checks involving items that are valued by weight, including anything made of precious metals." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9126f19d-85c1-43dd-8864-3bcd862e3b41"),
                SourceId = CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
