using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterials.Instances
{
    public class Warpglass : Template
    {
        public static readonly Guid ID = Guid.Parse("3d6d6740-5c9f-480d-8752-0f5a2a5d432a");

        protected override PreciousMaterial GetMaterial()
        {
            return new PreciousMaterial
            {
                Id = ID,
                Name = "Warpglass",
                WeaponId = PreciousMaterialWeapons.Instances.WarpglassWeapon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1abd5780-c3f7-4feb-b8c1-968033cf66d3"), Type = TextBlockType.Text, Text = "This bizarre substance is fashioned from the raw, chaotic quintessence of the Maelstrom. It can be fashioned into weapons and items, but is too unstable to make into useful armor or shields." };
            yield return new TextBlock { Id = Guid.Parse("dd297220-6c3a-4f32-808f-1db97da763fb"), Type = TextBlockType.Text, Text = "Raw warpglass is an opalescent glassy material with surprising strength. When worked, it changes its appearance—though not its properties—to appear as random striations of other metals and types of stone." };
        }

        protected override IEnumerable<PreciousMaterialItem> GetItems()
        {
            yield break;
        }

        protected override IEnumerable<PreciousMaterialVariant> GetVariants()
        {
            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("2fd8e026-1782-443a-aa53-11140c5800a4"),
                Name = "Warpglass Chunk",
                BulkId = Bulks.Instances.LightBulk.ID,
                ItemLevel = 0,
                Price = 80000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("b3b2cd33-e50c-4e7d-9eaf-34cf7f26cd71"),
                Name = "Warpglass Ingot",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 0,
                Price = 800000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("6e4e845c-594a-4e34-8bab-73b7996dfcb5"),
                Name = "Warpglass Item",
                NameAddendum = "High Grade",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 17,
                Price = 800000
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Precious.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9ccb242-0b6d-424c-acbe-e51662a7064f"),
                SourceId = Sources.Instances.Pathfinder162.ID,
                Page = 74
            };
        }
    }
}
