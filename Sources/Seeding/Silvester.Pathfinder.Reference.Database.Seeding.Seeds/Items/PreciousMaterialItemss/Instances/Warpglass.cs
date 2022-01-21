using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.PreciousMaterialItems.Instances
{
    public class Warpglass : Template
    {
        public static readonly Guid ID = Guid.Parse("16da645f-1805-4ce6-b432-9aea5e81274c");

        protected override PreciousMaterialItem GetPreciousMaterialItem()
        {
            return new PreciousMaterialItem
            {
                Id = ID,
                Name = "Warpglass",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1abd5780-c3f7-4feb-b8c1-968033cf66d3"), "This bizarre substance is fashioned from the raw, chaotic quintessence of the Maelstrom. It can be fashioned into weapons and items, but is too unstable to make into useful armor or shields.");;
            builder.Text(Guid.Parse("dd297220-6c3a-4f32-808f-1db97da763fb"), "Raw warpglass is an opalescent glassy material with surprising strength. When worked, it changes its appearance—though not its properties—to appear as random striations of other metals and types of stone.");;
        }

        protected override IEnumerable<PreciousMaterialItemVariant> GetPreciousMaterialItemVariants()
        {
            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("2fd8e026-1782-443a-aa53-11140c5800a4"),
                Name = "Warpglass Chunk",
                Level = 0,
                Price = 80000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("b3b2cd33-e50c-4e7d-9eaf-34cf7f26cd71"),
                Name = "Warpglass Ingot",
                Level = 0,
                Price = 800000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("6e4e845c-594a-4e34-8bab-73b7996dfcb5"),
                Name = "Warpglass Item (High Grade)",
                Level = 17,
                Price = 800000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3f5a97a6-9b91-4f3b-b48a-d00d30236523"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("34ce74c2-5b99-4f94-adb4-db5ac81a75f5"), Traits.Instances.Precious.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64da2a00-140d-423d-9be6-1141952ab8c0"),
                SourceId = Sources.Instances.Pathfinder162.ID,
                Page = 74
            };
        }
    }
}
