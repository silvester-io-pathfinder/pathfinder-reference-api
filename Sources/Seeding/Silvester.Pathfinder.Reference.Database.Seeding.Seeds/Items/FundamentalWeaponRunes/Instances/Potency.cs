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
    public class Potency : Template
    {
        public static readonly Guid ID = Guid.Parse("907264a7-e146-493c-a8ae-33c406a25b33");

        public static readonly Guid STANDARD_ID = Guid.Parse("00b9a1d0-0a0f-4530-9b0d-5f37d3e74be6");
        public static readonly Guid GREATER_ID = Guid.Parse("c4d8c65c-bd33-4451-8e0f-cdd395e8563c");
        public static readonly Guid MAJOR_ID = Guid.Parse("8445ece9-ecb7-4da7-b6e9-d9e6d4ffd8cc");

        protected override FundamentalWeaponRune GetFundamentalWeaponRune()
        {
            return new FundamentalWeaponRune
            {
                Id = ID,
                Name = "Weapon Potency Rune",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("02e64508-1a08-461d-b94b-4ecb7a4ddbac"), "Magical enhancements make this weapon strike true." );
            builder.Text(Guid.Parse("4940b654-9d55-4d56-86b5-fca5c9f1b9ef"), "You can upgrade the weapon potency rune already etched on a weapon to a stronger version, increasing the values of the existing rune to those of the new rune. You must have the formula of the stronger rune to do so, and the Price of the upgrade is the difference between the two runes' Prices." );
        }

        protected override IEnumerable<FundamentalWeaponRuneVariant> GetFundamentalWeaponRuneVariants()
        {
            yield return new FundamentalWeaponRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Potency",
                Usage = "Etched onto a weapon.",
                CraftingRequirements = "You are an expert in Crafting.",
                Level = 2,
                Price = 3500,
                RarityId = Rarities.Instances.Common.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                PotencyId = Potencies.Instances.Minor.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("aca9e4e4-2a3d-43a6-b6e8-103566b080f3"), "Attack rolls with this weapon gain a +1 item bonus, and the weapon can be etched with one property rune.")
                    .Build(),
            };

            yield return new FundamentalWeaponRuneVariant
            {
                Id = GREATER_ID,
                Name = "Potency (Greater)",
                Usage = "Etched onto a weapon.",
                CraftingRequirements = "You are a master in Crafting.",
                Level = 10,
                Price = 93500,
                RarityId = Rarities.Instances.Common.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("e6fce97a-533d-4c55-9aa6-455a11c30c55"), "The item bonus to attack rolls is +2, and the weapon can be etched with two property runes.")
                    .Build(),
            };

            yield return new FundamentalWeaponRuneVariant
            {
                Id = MAJOR_ID,
                Name = "Potency (Major)",
                Usage = "Etched onto a weapon.",
                CraftingRequirements = "You are legendary in Crafting.",
                Level = 16,
                Price = 893500,
                RarityId = Rarities.Instances.Common.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("95d3adf4-6b30-4762-93b9-6d3af0921583"), "The item bonus to attack rolls is +3, and the weapon can be etched with three property runes.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ddfa7cb1-147a-4c58-abc1-bacdab4be53b"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("2a2f95a8-d12d-4101-8456-c3dec48b2d09"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d22db014-7b95-449a-b459-ac8db99a9ba5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 581
            };
        }
    }
}
