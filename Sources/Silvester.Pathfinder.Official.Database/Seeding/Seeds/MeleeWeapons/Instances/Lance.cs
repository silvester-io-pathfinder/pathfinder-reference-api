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
    public class Lance : Template
    {
        public static readonly Guid ID = Guid.Parse("27dd4f47-af0a-460f-9b4f-6d841b1d702e");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Lance",
                Description = "This spear-like weapon is used by a mounted creature to deal a great deal of damage.",
                Price = 100,
                Damage = "1d8",
                Hands = "2",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Spear.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Jousting.ID;
            yield return Traits.Instances.Reach.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae37faf4-c071-4dd9-bdda-262e1495fc78"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
