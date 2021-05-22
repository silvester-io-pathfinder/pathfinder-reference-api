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
    public class Flail : Template
    {
        public static readonly Guid ID = Guid.Parse("0887fa4f-7650-443d-af1b-2d8e23fe5a8c");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Flail",
                Description = "This weapon consists of a wooden handle attached to a spiked ball or cylinder by a chain, rope, or strap of leather.",
                Price = 100,
                Damage = "1d6",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Flail.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disarm.ID;
            yield return Traits.Instances.Sweep.ID;
            yield return Traits.Instances.Trip.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("139c816a-ef93-4a2d-9867-0fd641a4f3dd"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
