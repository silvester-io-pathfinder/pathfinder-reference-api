using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Frost : Template
    {
        public static readonly Guid ID = Guid.Parse("fb4d332f-a643-4f63-8c5f-b99383dbef4a");

        public static readonly Guid STANDARD_ID = Guid.Parse("1b57fea8-cdc8-4899-8cdb-f84700bfe741");
        public static readonly Guid GREATER_ID = Guid.Parse("86cccc3e-defb-448b-82a7-48b14c021cb5");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Frost",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c027d501-04ab-4699-b417-55d66cbf3da9"), "This weapon is empowered with freezing ice. It deals an additional 1d6 cold damage on a successful Strike. On a critical hit, the target is also slowed 1 until the end of your next turn unless it succeeds at a DC 24 Fortitude save.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Frost",
                Usage = "Etched onto a weapon.",
                Level = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Frost (Greater)",
                Usage = "Etched onto a weapon.",
                Level = 15,
                Price = 650000,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("741897ff-c80f-4e5d-ac1e-72c809c9fef5"), "The save DC is 34. Cold damage dealt by this weapon ignores the target's cold resistance.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("60fd11b4-7156-434e-b4ef-365c372d7401"), Traits.Instances.Cold.ID);
            builder.Add(Guid.Parse("063d2c87-7201-419b-9f63-b48752821a66"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("bae36fa5-e858-4c2c-ae31-7d8addc015a1"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb151d6c-36e8-4369-a797-3feab8022e4e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
