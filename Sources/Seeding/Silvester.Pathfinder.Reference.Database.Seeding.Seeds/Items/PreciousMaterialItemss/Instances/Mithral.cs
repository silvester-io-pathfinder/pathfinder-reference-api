using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.PreciousMaterialItems.Instances
{
    public class Mithral : Template
    {
        public static readonly Guid ID = Guid.Parse("6e1fc7ca-5b8d-4ef7-87b5-61f0af1353fc");

        protected override PreciousMaterialItem GetPreciousMaterialItem()
        {
            return new PreciousMaterialItem
            {
                Id = ID,
                Name = "Mithral",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f2112b91-2fe0-4160-80af-bd9cfa4f77a5"), "Mithral is renowned for its lightness, durability, and effectiveness against a range of creatures including devils and lycanthropes. It has the same sheen as silver but a slightly lighter hue. Mithral weapons and armor are treated as if they were silver for the purpose of damaging creatures with weakness to silver. A metal item made of mithral is lighter than one made of iron or steel: the item's Bulk is reduced by 1 (reduced to light Bulk if its normal Bulk is 1, with no effect on an item that normally has light Bulk). The Price of an item made of this material is based on the item's normal Bulk, not its reduced Bulk for being made of mithral, but reduce the Bulk before making any further Bulk adjustments for the size of the item.");;
        }

        protected override IEnumerable<PreciousMaterialItemVariant> GetPreciousMaterialItemVariants()
        {
            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("4fee8850-4578-4b9a-be3d-0f8e12921850"),
                Name = "Mithral Chunk",
                Level = 0,
                Price = 50000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("9e69ae02-bf52-4fab-98a7-8b8f893cd952"),
                Name = "Mithral Ingot",
                Level = 0,
                Price = 500000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("f885fd24-e9e4-4407-a591-453d41141b49"),
                Name = "Mithral Object (Standard Grade)",
                Level = 8,
                Price = 35000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("e6d5ad1a-364a-4816-94f1-05e651963fce"),
                Name = "Mithral Object (High Grade)",
                Level = 16,
                Price = 600000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a8ae6709-2ae4-4f74-9cbc-f0d9b4d8679f"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("68393d70-c27a-4a39-a348-36a31503cb9b"), Traits.Instances.Precious.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ec9fc8c-0c70-4996-b352-794cc0ae59af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 579
            };
        }
    }
}
