using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.PreciousMaterialItems.Instances
{
    public class Adamantine : Template
    {
        public static readonly Guid ID = Guid.Parse("9c35545a-3c29-4034-baca-579bfc22363c");

        protected override PreciousMaterialItem GetPreciousMaterialItem()
        {
            return new PreciousMaterialItem
            {
                Id = ID,
                Name = "Adamantine",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5829ae74-0fca-4b15-937c-a6ef2dc17a5c"), "Mined from rocks that fell from the heavens, adamantine is one of the hardest metals known. It has a shiny, black appearance, and it is prized for its amazing resiliency and ability to hold an incredibly sharp edge.");;
        }

        protected override IEnumerable<PreciousMaterialItemVariant> GetPreciousMaterialItemVariants()
        {
            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("d0ffa114-5af2-4660-8ac6-b3702242993c"),
                Name = "Adamantine Chunk",
                Level = 0,
                Price = 50000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("1d32e18c-edf0-4e27-b0e4-c788b28c70c4"),
                Name = "Adamantine Ingot",
                Level = 0,
                Price = 500000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("2d238ecb-edb4-40e3-b109-fb649d767c89"),
                Name = "Adamantine Object (Standard Grade)",
                Level = 8,
                Price = 35000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("4f99400d-c32f-4806-85ba-2f8282f30c27"),
                Name = "Adamantine Object (High Grade)",
                Level = 16,
                Price = 600000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("eed755a3-735f-4bce-8eae-5d4bcf1a671c"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("5f9f9e55-7fb7-486a-8f10-ed4d54962e9c"), Traits.Instances.Precious.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9a6b9ab-5081-4641-bd07-911b89c15f78"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 578
            };
        }
    }
}
