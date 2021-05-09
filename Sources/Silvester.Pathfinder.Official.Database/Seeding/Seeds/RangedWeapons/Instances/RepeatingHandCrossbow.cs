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
    public class RepeatingHandCrossbow : AbstractRangedWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("c5272f9b-93f4-42d6-baa1-7262fb6cd1ec");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Repeating Hand Crossbow",
                Description = "This weapon features an ingeniously designed catch mechanism at the top of the flight grove, just in front of the latch, which automatically loads a bolt from a magazine and resets the string each time the weapon is fired. A typical repeating hand crossbow magazine holds five bolts.",
                Range = 60,
                Reload = 0,
                Price = 1000,
                Damage = "1d6",
                Hands = "1",
                AmmunitionId = RepeatingHandCrossbowMagazine.ID,
                BulkId = LightBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = Bow.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Repeating.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f97d2f26-6130-4d23-aac8-015e07958054"),
                SourceId = Pathfinder165.ID,
                Page = 73
            };
        }
    }
}
