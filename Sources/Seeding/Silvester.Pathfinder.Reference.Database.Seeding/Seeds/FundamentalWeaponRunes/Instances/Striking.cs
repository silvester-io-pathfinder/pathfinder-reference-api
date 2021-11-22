using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FundamentalWeaponRunes.Instances
{
    public class Striking : Template
    {
        public static readonly Guid ID = Guid.Parse("2f974d18-6a4a-4f02-8a73-8365376152e3");

        protected override FundamentalWeaponRune GetRune()
        {
            return new FundamentalWeaponRune
            {
                Id = ID,
                Name = "Weapon Striking Rune"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1e34371c-5e72-4bb0-ae4e-eb3ff196ff19"), Type = TextBlockType.Text, Text = "You can upgrade the striking rune already etched on a weapon to a stronger version, increasing the values of the existing rune to those of the new rune. You must have the formula of the stronger rune to do so, and the Price of the upgrade is the difference between the two runes' Prices." };
        }

        protected override IEnumerable<FundamentalWeaponRuneVariant> GetLevels()
        {
            yield return new FundamentalWeaponRuneVariant
            {
                Id = Guid.Parse("9314e2b0-f97d-4b66-a1fb-2a595da495ce"),
                Name = "Standard",
                Benefits = "A striking rune stores destructive magic in the weapon, increasing the weapon damage dice it deals to two instead of one. For instance, a +1 striking dagger would deal 2d4 damage instead of 1d4 damage.",
                ItemLevel = 4,
                Price = 6500
            };

            yield return new FundamentalWeaponRuneVariant
            {
                Id = Guid.Parse("bfb41563-5fb7-465e-9f76-b92fe512a730"),
                Name = "Greater",
                Benefits = "The weapon deals three weapon damage dice.",
                ItemLevel = 12,
                Price = 106500
            };

            yield return new FundamentalWeaponRuneVariant
            {
                Id = Guid.Parse("b610dc2b-6ce1-48b7-9c9d-23e1f2f7a4ae"),
                Name = "Major",
                Benefits = "The weapon deals four weapon damage dice.",
                ItemLevel = 19,
                Price = 3106500
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
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
