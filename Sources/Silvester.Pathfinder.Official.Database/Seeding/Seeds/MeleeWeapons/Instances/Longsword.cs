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
    public class Longsword : Template
    {
        public static readonly Guid ID = Guid.Parse("44cbf854-e9a3-4562-b5d5-f4b4ea583a76");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Longsword",
                Description = "Longswords can be one-edged or two‑edged swords. Their blades are heavy and they’re between 3 and 4 feet in length.",
                Price = 100,
                Damage = "1d8",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Slashing.ID
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
                Id = Guid.Parse("d2c680c9-f47f-4bce-b8a8-d1c6690f11a4"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
