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
    public class Scourge : Template
    {
        public static readonly Guid ID = Guid.Parse("299de1cf-c922-4a22-b924-38a9f345f8e7");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Scourge",
                Description = "A scourge (also known as a cat-o'-nine-tails) is a set of several knotted cords made from cotton or leather and attached to a handle. While most scourges are more suitable for torture than combat, the weapons used by the Order of the Scourge have metal barbs woven in to pierce clothing and armor. The scourge is a martial melee weapon.",
                Price = 10,
                Damage = "1d4",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Flail.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Disarm.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Nonlethal.ID;
            yield return Traits.Instances.Sweep.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9525a2a2-bf28-40fe-a616-7d75151e2540"),
                SourceId = CharacterGuide.ID,
                Page = 80
            };
        }
    }
}
