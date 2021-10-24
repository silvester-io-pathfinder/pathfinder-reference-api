using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RangedWeapons.Instances
{
    public class ThunderSling : Template
    {
        public static readonly Guid ID = Guid.Parse("2681245d-4754-4426-be9e-34d7ba96128f");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Thunder Sling",
                Description = "Tengu use these specialized slings to fire darts further and with greater force than when thrown by hand, which is particularly effective when attacking from great heights. A thunder sling uses darts as ammunition. It can also hurl blowgun darts as ammunition but deals 1d4 piercing damage instead of 1d6 when used this way.",
                Range = 50,
                Reload = 1,
                Price = 500,
                Damage = "1d6",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Sling.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Propulsive.ID;
            yield return Traits.Instances.Tengu.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2523e56-dad3-4c5c-8787-4b13ab0c823a"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
