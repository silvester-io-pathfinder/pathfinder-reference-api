using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class FilchersFork : Template
    {
        public static readonly Guid ID = Guid.Parse("285c5d1b-a837-4065-9005-28420b0b8e00");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Filcher's Fork",
                Description = "This halfling weapon looks like a long, two-pronged fork and is used as both a weapon and a cooking implement.",
                Price = 100,
                Damage = "1d4",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Spear.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Backstabber.ID;
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Thrown.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd7c2cd0-bfe4-4175-9926-f65cb443f34e"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
