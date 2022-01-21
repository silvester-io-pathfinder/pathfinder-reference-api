using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Fearsome : Template
    {
        public static readonly Guid ID = Guid.Parse("0cf9a028-72a8-44ad-82c6-72f6bd9351a3");
        public static readonly Guid STANDARD_ID = Guid.Parse("f40bf60b-e57d-4021-b7b9-4b98c8eb62c6");
        public static readonly Guid GREATER_ID = Guid.Parse("e2c40d60-9c36-4dfa-a877-2c240993a9e2");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Fearsome",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("db638e68-2428-4c0c-a41d-1bf5043b1264"), "When you critically hit with this weapon, the target becomes frightened 1.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Fearsome",
                Usage = "Etched onto a weapon.",
                Level = 5,
                Price = 16000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Fearsome (Greater)",
                Usage = "Etched onto a weapon.",
                Level = 12,
                Price = 200000,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ddbe3dfd-fdd0-498c-a580-58bf270bb7fe"), "When you critically hit with this weapon, the target becomes frightened 2.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1087c4d6-0813-494a-b8e4-26cf11a836b6"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("c74347d0-c6ce-4d32-8018-abdb0eaebad8"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("591591d1-723d-489b-8302-59817b2a9155"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("1c6d5afe-1bbc-4d41-828d-53a40310f787"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("4cbdcee1-a76d-4584-8a76-95a5ac25c3e9"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f7cd5a7-5142-4f35-a103-b8146f1739a0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 260
            };
        }
    }
}
