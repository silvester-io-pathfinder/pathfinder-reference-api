using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class BasicCraftersBook : Template
    {
        public static readonly Guid ID = Guid.Parse("45716613-931a-42c5-8cb0-ce77190b1cb8");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Basic Crafter's Book",
                Hands = "2",
                Price = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("333536c8-6a6d-4462-a8f7-67a8e5758830"), Type = TextBlockType.Text, Text = "This book contains formulas for Crafting common items." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6efbc37c-386e-47d0-8b8b-169b2d4e53b8"),
                SourceId = CoreRulebook.ID,
                Page = 289
            };
        }
    }
}
