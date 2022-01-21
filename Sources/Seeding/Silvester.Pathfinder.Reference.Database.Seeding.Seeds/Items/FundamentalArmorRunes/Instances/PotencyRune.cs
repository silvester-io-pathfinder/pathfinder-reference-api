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
    public class PotencyRune : Template
    {
        public static readonly Guid ID = Guid.Parse("aa56af92-069d-4cfd-81e6-ab2af589f662");

        public static readonly Guid STANDARD_ID = Guid.Parse("47f5b617-be1e-47f8-b165-bf6b5cc705cd");
        public static readonly Guid GREATER_ID = Guid.Parse("238aa717-ede1-4cae-87c2-fe17a69860bd");
        public static readonly Guid MAJOR_ID = Guid.Parse("b5330c4e-a43b-4367-a69a-cfb63fe01d06");

        protected override FundamentalArmorRune GetFundamentalArmorRune()
        {
            return new FundamentalArmorRune
            {
                Id = ID,
                Name = "Armor Potency Rune",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a7f4f82a-f5e4-485c-a38c-c115f33df11f"), "Magic wards deflect attacks.");
            builder.Text(Guid.Parse("3aa7b1ef-a9fe-4fe4-9943-ee40d8cbc528"), "You can upgrade the armor potency rune already etched on a suit of armor to a stronger version, increasing the values of the existing rune to those of the new rune. You must have the formula of the stronger rune to do so, and the Price of the upgrade is the difference between the two runes' Prices.");
        }

        protected override IEnumerable<FundamentalArmorRuneVariant> GetFundamentalArmorRuneVariants()
        {
            yield return new FundamentalArmorRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Potency",
                Usage = "Etched onto armor.",
                Level = 5,
                Price = 16000,
                RarityId = Rarities.Instances.Common.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                PotencyId = Potencies.Instances.Minor.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("cb491174-4682-423e-8555-4239e29fb9e2"), "Increase the armor's item bonus to AC by 1. The armor can be etched with one property rune.")
                    .Build()
            };

            yield return new FundamentalArmorRuneVariant
            {
                Id = GREATER_ID,
                Name = "Potency (Greater)",
                Usage = "Etched onto armor.",
                Level = 11,
                Price = 106000,
                RarityId = Rarities.Instances.Common.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("34424d74-ca95-4ec4-b117-fe5d3160518b"), "Increase the armor's item bonus to AC by 2, and the armor can be etched with two property runes.")
                    .Build()
            };

            yield return new FundamentalArmorRuneVariant
            {
                Id = MAJOR_ID,
                Name = "Potency (Major)",
                Usage = "Etched onto armor.",
                Level = 18,
                Price = 2056000,
                RarityId = Rarities.Instances.Common.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0f3c9cb2-b79c-4b16-98b2-9eca8016f7b2"), "Increase the armor's item bonus to AC by 3, and the armor can be etched with three property runes.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ab65e535-4381-48c5-8be6-66ebf0176dbf"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("75047c10-d256-431c-ab6d-705e1e3c5e24"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9b00728-bb97-4e1a-9346-b85b2d4ebf5e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 581
            };
        }
    }
}
