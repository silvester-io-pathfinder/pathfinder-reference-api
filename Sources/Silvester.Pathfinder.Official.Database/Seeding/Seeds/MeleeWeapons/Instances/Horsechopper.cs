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
    public class Horsechopper : Template
    {
        public static readonly Guid ID = Guid.Parse("c3d2c58d-904d-4fb5-9246-bc292a95ba8e");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Horsechopper",
                Description = "Created by goblins to battle horses, this weapon is essentially a long shaft ending in a blade with a large hook.",
                Price = 90,
                Damage = "1d8",
                Hands = "2",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Polearm.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Goblin.ID;
            yield return Traits.Instances.Reach.ID;
            yield return Traits.Instances.Trip.ID;
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Versatile.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bde76d4-71e5-40d2-994e-473c24c1f2d5"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
