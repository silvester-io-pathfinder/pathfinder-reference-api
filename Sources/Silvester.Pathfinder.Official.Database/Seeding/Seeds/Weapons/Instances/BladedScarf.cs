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
    public class BladedScarf : AbstractWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Weapon GetWeapon()
        {
            return new Weapon
            {
                Id = ID,
                Name = "Bladed Scarf",
                Description = "The thin metal plates interwoven throughout this long scarf turn a fashion accessory into a deadly weapon.",
                Price = 300,
                Damage = "1d8",
                Hands = 2,
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Flail.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disarm.ID;
            yield return Traits.Instances.Reach.ID;
            yield return Traits.Instances.Sweep.ID;
            yield return Traits.Instances.Trip.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = GodsAndMagic.ID,
                Page = 120
            };
        }
    }
}
