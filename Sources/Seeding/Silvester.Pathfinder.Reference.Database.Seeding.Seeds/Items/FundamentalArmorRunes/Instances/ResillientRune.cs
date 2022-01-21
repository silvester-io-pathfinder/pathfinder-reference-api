using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.FundamentalArmorRunes.Instances
{
    public class ResillientRune : Template
    {
        public static readonly Guid ID = Guid.Parse("412582f8-84db-4344-a9cf-5d8e1208f72e");

        public static readonly Guid STANDARD_ID = Guid.Parse("6683a69a-90e0-4cfc-915f-a1e044a8c3e1");
        public static readonly Guid GREATER_ID = Guid.Parse("44794e5c-af23-47d9-90fe-25384c7b8bf9");
        public static readonly Guid MAJOR_ID = Guid.Parse("13e71b88-5fa6-4da7-bf26-90c0d9044983");

        protected override FundamentalArmorRune GetFundamentalArmorRune()
        {
            return new FundamentalArmorRune
            {
                Id = ID,
                Name = "Armor Resillient Rune",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1aa8fb59-3d43-49d3-b5e0-e85a02b66419"), "Resilient runes imbue armor with additional protective magic.");
            builder.Text(Guid.Parse("81c79bd9-a634-4de6-98e8-5e7c621becb2"), "You can upgrade the resilient rune already etched on a suit of armor to a stronger version, increasing the values of the existing rune to those of the new rune. You must have the formula of the stronger rune to do so, and the Price of the upgrade is the difference between the two runes' Prices.");
        }

        protected override IEnumerable<FundamentalArmorRuneVariant> GetFundamentalArmorRuneVariants()
        {
            yield return new FundamentalArmorRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Resillient",
                Usage = "Etched onto armor.",
                Level = 8,
                Price = 34000,
                RarityId = Rarities.Instances.Common.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6b007e08-4399-45d5-9da9-591409542e43"), "The armor grants a +1 item bonus to saving throws.")
                    .Build()
            };

            yield return new FundamentalArmorRuneVariant
            {
                Id = GREATER_ID,
                Name = "Resillient (Greater)",
                Usage = "Etched onto armor.",
                Level = 14,
                Price = 344000,
                RarityId = Rarities.Instances.Common.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0ca360d5-df28-42b8-a8e6-374f82731a5c"), "The armor grants a +2 item bonus to saving throws.")
                    .Build()
    };

            yield return new FundamentalArmorRuneVariant
            {
                Id = MAJOR_ID,
                Name = "Resillient (Major)",
                Usage = "Etched onto armor.",
                Level = 20,
                Price = 4944000,
                RarityId = Rarities.Instances.Common.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("51de9002-96e1-4d91-b1a9-9d8a57b78a4a"), "The armor grants a +3 item bonus to saving throws.")
                    .Build()
};
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("cc80f576-b0aa-42cd-9257-a02773afdbd5"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("bb05e17f-1a42-4bd9-b051-4816175c5bc6"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03bc38ca-cc39-4179-b938-cd39502e445b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 581
            };
        }
    }
}
