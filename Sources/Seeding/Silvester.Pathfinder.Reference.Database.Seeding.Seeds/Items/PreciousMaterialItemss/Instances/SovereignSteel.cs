using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.PreciousMaterialItems.Instances
{
    public class SovereignSteel : Template
    {
        public static readonly Guid ID = Guid.Parse("79fd8c4f-8397-4361-ab7c-f7d00bcfb0f8");

        protected override PreciousMaterialItem GetPreciousMaterialItem()
        {
            return new PreciousMaterialItem
            {
                Id = ID,
                Name = "Sovereign Steel",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b43177bf-d305-434a-bbcb-0ef6fc2e5bf8"), "Created by Black Sovereign Kevoth-Kul, this unique alloy of cold iron and the skymetal noqual can provide protection from magical assault. The process of cold-forging the two materials together is quite complicated and precise. Characters in search of sovereign steel weapons and armor will almost assuredly have to travel to Starfall to procure gear made from this rare alloy. While some believe it possible to craft shields of sovereign steel as well, in one of his fits, Kevoth-Kul yelled that he had no use for them and banned anyone from making such a thing. So far, his smiths have been too afraid to confirm whether or not it was a joke. All sovereign steel items (including weapon and armor below) have a +4 circumstance bonus on saves against magic that the item makes, and grant their bonus to saves the owner makes specifically to protect the item from magic (such as against the rusting grasp spell).");;
        }

        protected override IEnumerable<PreciousMaterialItemVariant> GetPreciousMaterialItemVariants()
        {
            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("6ec03653-f64d-4b18-8cc4-c83bcdbdebda"),
                Name = "Sovereign Steel Chunk",
                Level = 0,
                Price = 70000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("a2888ed2-ec5c-4bfc-a606-85eaec351e8f"),
                Name = "Sovereign Steel Ingot",
                Level = 0,
                Price = 700000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("81db1090-4b6a-46f0-b66e-ee03a8713344"),
                Name = "Sovereign Steel Object (Standard Grade)",
                Level = 9,
                Price = 50000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("050d3b7e-0c23-4976-a84d-629a8ff4f9f9"),
                Name = "Sovereign Steel Object (High Grade)",
                Level = 17,
                Price = 800000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c5913e54-2bb1-4a6e-aba1-149bd69c4dca"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("ce6c07ea-ebc2-4721-935c-dd374508743d"), Traits.Instances.Precious.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f45cbea2-b57d-4274-a342-599b236dc8b7"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 77
            };
        }
    }
}
