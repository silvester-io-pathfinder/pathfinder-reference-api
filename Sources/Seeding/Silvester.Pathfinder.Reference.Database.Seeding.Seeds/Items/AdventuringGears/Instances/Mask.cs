using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Mask : Template
    {
        public static readonly Guid ID = Guid.Parse("034b11f6-b634-4a46-b78b-0239ea1d0fe6");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Mask",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8d164401-9455-49f8-8512-258a8233cd64"), "A mask helps you use the Impersonate action to pass yourself off as someone you aren't.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("c4939b1b-1059-469d-a6c9-0a335a3c38c6"),
                Name = "Mask (Ordinary)",
                Usage = "Worn mask.",
                Level = 0,
                Price = 5,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("81ac081c-1b16-4573-b6e2-6773edcf295a"), "This ordinary mask is made out of cheap material, such as paper-mâché or simple cloth. This can be specially fitted over another mask.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("730bb02d-9543-456c-bdf3-5a9807df0f7a"),
                Name = "Mask (Fine)",
                Usage = "Worn mask.",
                Level = 0,
                Price = 200,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("d08ff6e8-7733-40e7-9d0d-bc4753f0e7ab"), "This well-crafted mask, suitable for a noble at a masquerade, is made with impeccable craftsmanship and expensive material, such as porcelain and gold filigree.")
                   .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("70b65590-6690-4fb8-8b48-d5d9efe9a23b"),
                Name = "Mask (Plague)",
                Usage = "Worn mask.",
                Level = 1,
                Price = 1000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("b3f546be-6935-4cfb-ab84-f3bbc8277bbf"), "This stylized bird mask is equipped with a basic filter. The plague mask attempts to counteract any inhaled poisons or airborne diseases each round you breathe. The same replacement filters used in water purifiers can be used with a plague mask, granting you the counteract modifier and effects of the filter for 20 minutes. Plague masks are uncommon items because the filters they use to protect from inhaled poisons and diseases are themselves uncommon. As such, you can buy a plague mask without a filter as a common item, though it's usually more cost-effective to buy a fine mask in the shape of a plague mask in that case.")
                   .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("49d5504c-9807-4585-92f4-513bb2a39d7b"),
                Name = "Mask (Rubber)",
                Usage = "Worn mask.",
                Level = 1,
                Price = 500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("ff54078c-fd53-4d5d-bca9-3f42bd6ec258"), "Rubber masks are sculpted to resemble the face of another creature. You can use this mask to help decrease the difficulty of Impersonating a specific creature with a very different face than yours.")
                   .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2fd591bc-62e8-436a-b408-08559b76ecfc"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 92
            };
        }
    }
}
