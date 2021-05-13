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
    public class MonkeysFist : Template
    {
        public static readonly Guid ID = Guid.Parse("14f657da-fab9-4369-9fac-ded23f1d2b6f");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Monkey's Fist",
                Description = "Also called a 'slungshot', the monkey's fist is a short length of rope ending in a thick knot wrapped around a metal weight. You can tie the loose end of a monkey's fist to your wrist; if you are Disarmed, the weapon remains secured to your wrist rather than falling to the ground, though you must use an Interact action to grip it before using it again. A monkey's fist is a martial melee weapon.",
                Price = 10,
                Damage = "1d6",
                Hands = "1",
                BulkId = NegligibleBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Flail.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Monk.ID;
            yield return Traits.Instances.Nonlethal.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("341b16f6-b1ad-4bd7-b3a0-5b9cccff4e1e"),
                SourceId = Pathfinder157.ID,
                Page = 78
            };
        }
    }
}
