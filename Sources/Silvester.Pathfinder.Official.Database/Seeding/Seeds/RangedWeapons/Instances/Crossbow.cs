using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Ammunitions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RangedWeapons.Instances
{
    public class Crossbow : AbstractRangedWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("2ff08622-f9b8-4a19-8cf0-0f6c957762ee");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Crossbow",
                Description = "This ranged weapon has a bow-like assembly mounted on a handled frame called a tiller. The tiller has a mechanism to lock the bowstring in place, attached to a trigger mechanism that releases the tension and launches a bolt.",
                Range = 120,
                Reload = 1,
                Price = 300,
                Damage = "1d8",
                Hands = "2",
                AmmunitionId = Bolts.ID,
                BulkId = OneBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = Bow.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6d8ee85-bb06-4d89-abf3-4a3ba7fae0d6"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
