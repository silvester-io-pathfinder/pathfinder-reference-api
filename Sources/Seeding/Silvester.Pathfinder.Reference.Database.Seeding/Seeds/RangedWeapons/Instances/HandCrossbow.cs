using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ammunitions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RangedWeapons.Instances
{
    public class HandCrossbow : Template
    {
        public static readonly Guid ID = Guid.Parse("b0d15726-7cc1-4603-9363-f8127bb559d9");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Hand Crossbow",
                Description = "Sometimes referred to as an alley bow by rogues or ruffians, this small crossbow fires small bolts that are sometimes used to deliver poison to the target. It’s small enough to be shot one-handed, but it still requires two hands to load.",
                Range = 60,
                Reload = 1,
                Price = 300,
                Damage = "1d6",
                Hands = "1",
                AmmunitionId = Bolts.ID,
                BulkId = LightBulk.ID,
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
                Id = Guid.Parse("eb422b9d-3ca7-405c-9d0a-dbe77fb4fcda"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
