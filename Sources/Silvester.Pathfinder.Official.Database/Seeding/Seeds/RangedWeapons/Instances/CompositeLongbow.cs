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
    public class CompositeLongbow : AbstractRangedWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("c532d9bd-cc75-4a16-bb46-b63c06fa9917");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Composite Longbow",
                Description = "This projectile weapon is made from horn, wood, and sinew laminated together to increase the power of its pull and the force of its projectile. Like all longbows, its great size also increases the bow’s range and power. You must use two hands to fire it, and it cannot be used while mounted. Any time an ability is specifically restricted to a longbow, such as Erastil’s favored weapon, it also applies to composite longbows unless otherwise stated.",
                Range = 100,
                Reload = 0,
                Price = 2000,
                Damage = "1d8",
                Hands = "1+",
                AmmunitionId = Arrows.ID,
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Bow.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Propulsive.ID;
            yield return Traits.Instances.Volley.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f98fded2-6dfb-43ef-9ef1-2a0b9a9d6dae"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
