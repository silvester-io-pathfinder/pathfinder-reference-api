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
    public class TawLauncher : Template
    {
        public static readonly Guid ID = Guid.Parse("7f5df152-e9a8-4918-a561-2aae39f0938b");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Taw Launcher",
                Description = "Designed by conrasu warriors, this complex device resembles a crossbow and fires small wooden bullets known as taws. A system of blades within the launcher can rapidly reshape a taw as it's loaded, allowing the launcher to fire taws of different shapes, such as fléchettes.",
                Range = 100,
                Reload = 1,
                Price = 1000,
                Damage = "1d10",
                Hands = "2",
                AmmunitionId = WoodenTaws.ID,
                BulkId = OneBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = Bow.ID,
                DamageTypeId = Modular.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Modular.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c2cadd3-1f2e-442b-a75c-2cdfa563852e"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
