using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Weapons.Instances
{
    public class ThrowingKnife : AbstractWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Weapon GetWeapon()
        {
            return new Weapon
            {
                Id = ID,
                Name = "Throwing Knife",
                Description = "This light knife is optimally balanced to be thrown accurately at a greater distance than a common dagger. While this comes at the cost of a significant cutting edge, the difference is worth it for characters focused on thrown weapons.",
                Price = 30,
                Damage = "1d4",
                Hands = 1,
                BulkId = LightBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = Knife.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Thrown.ID;
            yield return Traits.Instances.Twin.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Pathfinder151.ID,
                Page = 77
            };
        }
    }
}
