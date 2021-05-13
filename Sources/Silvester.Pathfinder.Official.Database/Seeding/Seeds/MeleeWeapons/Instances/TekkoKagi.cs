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
    public class TekkoKagi : Template
    {
        public static readonly Guid ID = Guid.Parse("32823fbd-8598-4fc3-a9d9-769043cbce0f");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Tekko-Kagi",
                Description = "Four curved blades attached to a sturdy handlebar give the wielder of this close-combat weapon the illusion of having claws that extend from their fist. Adherents of Bastet favor the tekko-kagi for catching their foes off guard.",
                Price = 20,
                Damage = "1d4",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Brawling.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Disarm.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Parry.ID;
            yield return Traits.Instances.Trip.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d59eec71-20e8-49a6-82d4-9e5b309fa763"),
                SourceId = GodsAndMagic.ID,
                Page = 121
            };
        }
    }
}
