using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class Morningstar : Template
    {
        public static readonly Guid ID = Guid.Parse("9ebc3552-f0fa-450e-96bc-a5d73d18c8ea");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Morningstar",
                Description = "This weapon has a short shaft ending in a metal ball studded with spikes.",
                Price = 100,
                Damage = "1d6",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Club.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Versatile.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a894bf57-ddd3-4cfa-a05c-0f886d627ae4"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
