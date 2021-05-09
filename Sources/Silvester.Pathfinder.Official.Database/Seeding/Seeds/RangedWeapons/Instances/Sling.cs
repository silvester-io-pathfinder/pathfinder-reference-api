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
    public class Sling : AbstractRangedWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("26d5e7ba-84a2-46d5-966d-c8eeda6cf9a4");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Sling",
                Description = "Little more than a leather cup attached to a pair of straps, a sling can be used to fling smooth stones or sling bullets at a range.",
                Range = 50,
                Reload = 1,
                Price = 0,
                Damage = "1d6",
                Hands = "1",
                AmmunitionId = SlingBullets.ID,
                BulkId = LightBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Sling.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Propulsive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95ea6700-cabd-4454-8926-4e4a75a55b59"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
