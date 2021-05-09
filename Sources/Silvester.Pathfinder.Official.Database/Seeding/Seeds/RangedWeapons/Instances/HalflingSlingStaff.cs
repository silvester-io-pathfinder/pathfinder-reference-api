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
    public class HalflingSlingStaff : AbstractRangedWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("957a55d1-dbc4-4060-ac98-aa4523175510");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Halfling Sling Staff",
                Description = "This staff ends in a Y-shaped split that cradles a sling. The length of the staff provides excellent leverage when used two‑handed to fling rocks or bullets from the sling.",
                Range = 80,
                Reload = 1,
                Price = 500,
                Damage = "1d10",
                Hands = "2",
                AmmunitionId = SlingBullets.ID,
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Sling.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Halfling.ID;
            yield return Traits.Instances.Propulsive.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd06d5ba-e50c-461f-ac71-3271d52c9c3f"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
