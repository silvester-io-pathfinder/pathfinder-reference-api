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
    public class CompositeShortbow : Template
    {
        public static readonly Guid ID = Guid.Parse("d093010f-0b1b-41d0-b76e-c5532a2d99a5");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Composite Shortbow",
                Description = "This shortbow is made from horn, wood, and sinew laminated together to increase the power of its pull and the force of its projectile. Its compact size and power make it a favorite of mounted archers. Any time an ability is specifically restricted to a shortbow, it also applies to composite shortbows unless otherwise stated.",
                Range = 60,
                Reload = 0,
                Price = 1400,
                Damage = "1d6",
                Hands = "1+",
                AmmunitionId = Arrows.ID,
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Bow.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Propulsive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb97184c-4af3-4ac7-9bb4-3eb3d5999ab6"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
