using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Tool : Template
    {
        public static readonly Guid ID = Guid.Parse("473b09f6-8087-4fda-97df-103983c75d44");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Tool",
                Hands = "2",
                Price = 100,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ba51c149-5e99-44be-8fe4-6941b41d481a"), Type = TextBlockType.Text, Text = "This entry is a catchall for basic hand tools that don’t have a specific adventuring purpose. A hoe, shovel, or sledgehammer is a long tool, and a hand drill, ice hook, or trowel is a short tool. A tool can usually be used as an improvised weapon, dealing 1d4 damage for a short tool or 1d6 for a long tool. The GM determines the damage type that’s appropriate or adjusts the damage if needed." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("c35dfbc6-d401-45bc-bddd-7bba379f115d"),
                NameAddendum = "Long",
                DescriptionAddendum = "A hoe, shovel, or sledgehammer is a long tool. A tool can usually be used as an improvised weapon, dealing 1d6 for a long tool.",
                ItemLevel = 0,
                Price = 100,
                Hands = 2,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0bb59651-792b-4c55-8c1a-df199426e5c1"),
                NameAddendum = "Short",
                DescriptionAddendum = "A hand drill, ice hook, or trowel is a short tool. A tool can usually be used as an improvised weapon, dealing 1d4 damage for a short tool.",
                ItemLevel = 0,
                Price = 40,
                Hands = 1,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a91cebff-b88e-490d-85f2-4d01510c877f"),
                SourceId = CoreRulebook.ID,
                Page = 292
            };
        }
    }
}
