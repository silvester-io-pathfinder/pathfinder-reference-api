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
    public class Tool : Template
    {
        public static readonly Guid ID = Guid.Parse("473b09f6-8087-4fda-97df-103983c75d44");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Tool",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ba51c149-5e99-44be-8fe4-6941b41d481a"), "This entry is a catchall for basic hand tools that don't have a specific adventuring purpose. A hoe, shovel, or sledgehammer is a long tool, and a hand drill, ice hook, or trowel is a short tool. A tool can usually be used as an improvised weapon, dealing 1d4 damage for a short tool or 1d6 for a long tool. The GM determines the damage type that's appropriate or adjusts the damage if needed.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("c35dfbc6-d401-45bc-bddd-7bba379f115d"),
                Name = "Tool (Long)",
                Level = 0,
                Price = 100,
                Hands = "2",
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d6427bd7-837a-49bb-86c4-f72f0b140fff"), "A hoe, shovel, or sledgehammer is a long tool. A tool can usually be used as an improvised weapon, dealing 1d6 for a long tool.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0bb59651-792b-4c55-8c1a-df199426e5c1"),
                Name = "Tool (Short)",
                Level = 0,
                Price = 40,
                Hands = "1",
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5e490979-ae30-4608-876a-3a0a490fa886"), "A hand drill, ice hook, or trowel is a short tool. A tool can usually be used as an improvised weapon, dealing 1d4 damage for a short tool.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a91cebff-b88e-490d-85f2-4d01510c877f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 292
            };
        }
    }
}
