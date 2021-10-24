using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class Aklys : Template
    {
        public static readonly Guid ID = Guid.Parse("24f52641-1737-4761-8576-66710f258aab");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Aklys",
                Description = "The aklys is a throwing club with a hook on one end and a lengthy cord attached to the other. Though aklyses aren’t available in most shops, one might be purchased for 5 gp from a vendor that specializes in strange weapons.",
                Price = 500,
                Damage = "1d6",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = WeaponGroups.Instances.Club.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.RangedTrip.ID;
            yield return Traits.Instances.Tethered.ID;
            yield return Traits.Instances.Thrown.ID;
            yield return Traits.Instances.Trip.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f87e5121-6a39-400e-898d-8a8e50faedba"),
                SourceId = Bestiary.ID,
                Page = 85
            };
        }
    }
}
