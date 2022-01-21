using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Anchoring : Template
    {
        public static readonly Guid ID = Guid.Parse("5737e53b-ef08-4c02-b75e-47333cddc5e3");

        public static readonly Guid STANDARD_ID = Guid.Parse("0e28ddf4-9278-442e-9a9a-39200bb7eb14");
        public static readonly Guid GREATER_ID = Guid.Parse("76f621c1-7cc9-4733-bca2-af1cd108cad9");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Anchoring",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Anchoring",
                Usage = "Etched onto a weapon.",
                Level = 10,
                Price = 90000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Anchoring (Greater)",
                Usage = "Etched onto a weapon.",
                Level = 18,
                Price = 2200000,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("530dd6ef-734d-4e45-a276-dface3ab49f4"), "When you critically hit a target with a weapon with the anchoring rune, the weapon casts 8th-level dimensional anchor on the target (DC 38, counteract modifier +28), except that if the target critically succeeds at its Will save, instead of having no effect, the dimensional anchor lasts for 1 round. When you hit a target with the weapon but don't critically hit, the target is affected by 4th-level dimensional anchor for 1 round without a save (this still uses a counteract modifier of +28).")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("fd3f3ac8-262d-45be-8ff4-22235b99eb6c"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("6286b96e-6d98-4bbc-af5c-bb92b9a6eeaf"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("d0e5e936-2b6b-4acb-a966-f39cbb71d08b"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a9af1f0-c25d-4368-909c-804544c6fafe"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 80
            };
        }
    }
}
