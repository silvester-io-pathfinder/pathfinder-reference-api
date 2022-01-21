using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.FundamentalWeaponRunes.Instances
{
    public class Striking : Template
    {
        public static readonly Guid ID = Guid.Parse("2f974d18-6a4a-4f02-8a73-8365376152e3");

        public static readonly Guid STANDARD_ID = Guid.Parse("9314e2b0-f97d-4b66-a1fb-2a595da495ce");
        public static readonly Guid GREATER_ID = Guid.Parse("bfb41563-5fb7-465e-9f76-b92fe512a730");
        public static readonly Guid MAJOR_ID = Guid.Parse("b610dc2b-6ce1-48b7-9c9d-23e1f2f7a4ae");

        protected override FundamentalWeaponRune GetFundamentalWeaponRune()
        {
            return new FundamentalWeaponRune
            {
                Id = ID,
                Name = "Weapon Striking Rune",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1e34371c-5e72-4bb0-ae4e-eb3ff196ff19"), "You can upgrade the striking rune already etched on a weapon to a stronger version, increasing the values of the existing rune to those of the new rune. You must have the formula of the stronger rune to do so, and the Price of the upgrade is the difference between the two runes' Prices." );
        }

        protected override IEnumerable<FundamentalWeaponRuneVariant> GetFundamentalWeaponRuneVariants()
        {
            yield return new FundamentalWeaponRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Striking",
                Usage = "Eteched onto a weapon.",
                Level = 4,
                Price = 6500,
                RarityId = Rarities.Instances.Common.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("8739adae-65ca-497e-bb1d-39dec8d19a6d"), "A striking rune stores destructive magic in the weapon, increasing the weapon damage dice it deals to two instead of one. For instance, a +1 striking dagger would deal 2d4 damage instead of 1d4 damage.")
                    .Build(),
            };

            yield return new FundamentalWeaponRuneVariant
            {
                Id = GREATER_ID,
                Name = "Striking (Greater)",
                Usage = "Eteched onto a weapon.",
                Level = 12,
                Price = 106500,
                RarityId = Rarities.Instances.Common.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("71942b8c-6e54-4c6f-9b87-83dc4956dc45"), "A striking rune stores destructive magic in the weapon, increasing the weapon damage dice it deals to three instead of one. For instance, a +2 striking dagger would deal 3d4 damage instead of 1d4 damage.")
                    .Build(),
            };

            yield return new FundamentalWeaponRuneVariant
            {
                Id = MAJOR_ID,
                Name = "Striking (Major)",
                Usage = "Eteched onto a weapon.",
                Price = 3106500,
                Level = 19,
                RarityId = Rarities.Instances.Common.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("2f959a87-6579-4eaa-ac00-8c7253e6a031"), "A striking rune stores destructive magic in the weapon, increasing the weapon damage dice it deals to four instead of one. For instance, a +3 striking dagger would deal 4d4 damage instead of 1d4 damage.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7198fa78-44ea-422e-ab82-38085f325d1d"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("8345c545-096e-448c-90d8-9ee4dd6f3ae7"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b528556-e5c5-46e6-bfcf-8b755ab5947e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 581
            };
        }
    }
}
