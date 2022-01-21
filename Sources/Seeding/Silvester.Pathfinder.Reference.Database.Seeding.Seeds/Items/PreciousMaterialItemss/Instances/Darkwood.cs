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
    public class Darkwood : Template
    {
        public static readonly Guid ID = Guid.Parse("8bed2680-f2cc-4db5-8b6e-1fac3582d50a");

        protected override PreciousMaterialItem GetPreciousMaterialItem()
        {
            return new PreciousMaterialItem
            {
                Id = ID,
                Name = "Darkwood",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f4e2ec82-b861-440f-a478-7cd743c3d640"), "Darkwood is a very lightweight wood found primarily in old-growth forests in south-central Avistan; it is dark as ebony but has a slight purple tint. A darkwood item's Bulk is reduced by 1 (or to light Bulk if its normal Bulk is 1, with no effect on an item that normally has light Bulk). The Price of an item made of darkwood is based on the item's normal Bulk, not its reduced Bulk for being made of darkwood, but reduce the Bulk before making any further Bulk adjustments for the size of the item.");;
        }

        protected override IEnumerable<PreciousMaterialItemVariant> GetPreciousMaterialItemVariants()
        {
            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("81aaa9dc-86cb-47ef-a4fa-30f8287b03ee"),
                Name = "Darkwood Branch",
                Level = 0,
                Price = 50000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("563092d5-6ee1-4d5a-b5d2-3edd781d4f71"),
                Name = "Darkwood Lumber",
                Level = 0,
                Price = 500000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("78a7e5c4-afc2-4523-97f3-05703e296466"),
                Name = "Darkwood Object (Standard Grade)",
                Level = 8,
                Price = 35000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("5e3d48a5-7c71-4aea-92bb-6c08099fe5eb"),
                Name = "Darkwood Object (High Grade)",
                Level = 16,
                Price = 600000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0dbd8589-7f5e-4c66-aa31-404a2898f98e"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("489301b2-2efd-421c-b888-bbc3db3aecf2"), Traits.Instances.Precious.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3f1290b-ad8b-4654-acfa-76201cd11393"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 578
            };
        }
    }
}
