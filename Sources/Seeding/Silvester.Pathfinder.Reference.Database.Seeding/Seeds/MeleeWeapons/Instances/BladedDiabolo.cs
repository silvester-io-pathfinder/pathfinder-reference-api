using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class BladedDiabolo : Template
    {
        public static readonly Guid ID = Guid.Parse("3bf26277-c214-4a31-aa61-6ae3c3f75ea3");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Bladed Diabolo",
                Description = "This weapon consists of two bladed discs joined by a central axel, and is spun on a rope whose ends are attached to wand-like sticks. The wielder can hurl the diabolo from the rope like a stone from a sling, or swing it on the rope in melee.",
                Price = 200,
                Damage = "1d4",
                Hands = "2",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = WeaponGroups.Instances.Flail.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Backswing.ID;
            yield return Traits.Instances.Disarm.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Thrown.ID;
            yield return Traits.Instances.Trip.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f07df8e3-e1fa-4ca6-ae6b-6864594d348a"),
                SourceId = Pathfinder151.ID,
                Page = 77
            };
        }
    }
}
