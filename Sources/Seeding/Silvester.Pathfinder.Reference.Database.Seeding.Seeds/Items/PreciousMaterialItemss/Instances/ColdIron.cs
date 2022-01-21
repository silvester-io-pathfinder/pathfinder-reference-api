using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.PreciousMaterialItems.Instances
{
    public class ColdIron : Template
    {
        public static readonly Guid ID = Guid.Parse("ac517d80-af61-4e0a-a5b0-af7a9fc85789");

        protected override PreciousMaterialItem GetPreciousMaterialItem()
        {
            return new PreciousMaterialItem
            {
                Id = ID,
                Name = "Cold Iron",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("2fa636c4-57a8-450e-9a25-3cce978f3c61"), "Weapons made from cold iron are deadly to demons and fey alike. Cold iron looks like normal iron but is mined from particularly pure sources and shaped with little or no heat. This process is extremely difficult, especially for high-grade cold iron items.");;
        }

        protected override IEnumerable<PreciousMaterialItemVariant> GetPreciousMaterialItemVariants()
        {
            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("2f5b2bf5-6e4d-400b-8f77-092e0775a3da"),
                Name = "Cold Iron Chunk",
                Level = 0,
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("8540fd11-2d77-4ef0-84b4-bec2f4c303dd"),
                Name = "Cold Iron Ingot",
                Level = 0,
                Price = 10000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("9fe9bdba-ddb4-4881-9c36-b82fba29a653"),
                Name = "Cold Iron Object (Low Grade)",
                Level = 2,
                Price = 2000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("6f3fd4f0-6d38-4efe-8b97-84a56719a293"),
                Name = "Cold Iron Object (Standard Grade)",
                Level = 7,
                Price = 25000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("fa7999f5-fb3c-40d2-8f6f-6cbd01068502"),
                Name = "Cold Iron Object (High Grade)",
                Level = 15,
                Price = 450000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b15f2921-bfec-4c5e-bab9-967cd51f1f20"), Traits.Instances.Precious.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa939784-8c64-4fa1-bf0e-1fea96e9065f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 578
            };
        }
    }
}
