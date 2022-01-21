using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.PreciousMaterialItems.Instances
{
    public class Silver : Template
    {
        public static readonly Guid ID = Guid.Parse("49ce9bbe-dea0-4b4c-963b-449a5a34dc71");

        protected override PreciousMaterialItem GetPreciousMaterialItem()
        {
            return new PreciousMaterialItem
            {
                Id = ID,
                Name = "Silver",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("736cd527-7274-4ed9-8c7e-767fe2c1a4e7"), "Silver weapons are a bane to creatures ranging from devils to werewolves. Silver items are less durable than steel items, and low-grade silver items are usually merely silver-plated.");;
        }

        protected override IEnumerable<PreciousMaterialItemVariant> GetPreciousMaterialItemVariants()
        {
            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("079a76d3-94c6-46e3-93bc-29d25b3971b3"),
                Name = "Silver Chunk",
                Level = 0,
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("f7080cb1-ec21-4a60-8785-07857e1a9270"),
                Name = "Silver Ingot",
                Level = 0,
                Price = 10000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("9b739708-594c-4fb3-b639-bf3b8e477e90"),
                Name = "Silver Object (Low Grade)",
                Level = 2,
                Price = 2000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("358a0280-dc0a-4143-a680-01a0b9337c2c"),
                Name = "Silver Object (Standard Grade)",
                Level = 7,
                Price = 25000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("cc03a811-7974-4769-ba35-3493317be256"),
                Name = "Silver Object (High Grade)",
                Level = 15,
                Price = 450000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7d2ef7ff-7ef2-488e-80cb-b22676d4f98a"), Traits.Instances.Precious.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea1311ef-592c-4afa-a405-8feeaa626850"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 579
            };
        }
    }
}
