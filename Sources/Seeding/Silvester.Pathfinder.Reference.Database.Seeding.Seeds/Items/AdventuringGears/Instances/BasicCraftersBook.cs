using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
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
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("333536c8-6a6d-4462-a8f7-67a8e5758830"), "This book contains formulas for Crafting common items.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("fa487c24-24c8-4866-a2cf-49273cbfa544"),
                Name = "Basic Crafter's Book",
                Hands = "2",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6efbc37c-386e-47d0-8b8b-169b2d4e53b8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 289
            };
        }
    }
}
