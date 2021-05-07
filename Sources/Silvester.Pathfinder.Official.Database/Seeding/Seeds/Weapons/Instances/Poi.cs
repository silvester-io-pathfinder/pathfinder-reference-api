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
    public class Poi : AbstractWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Weapon GetWeapon()
        {
            return new Weapon
            {
                Id = ID,
                Name = "Poi",
                Description = "Poi are light weights tethered to ropes or chains. Performers swing the weights, usually one in each hand, in rhythmic patterns.",
                Price = 20,
                Damage = "1d4",
                Hands = 1,
                BulkId = LightBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = Flail.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
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
