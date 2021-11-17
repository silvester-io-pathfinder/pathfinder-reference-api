using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class ButterflySword : Template
    {
        public static readonly Guid ID = Guid.Parse("4d47aff7-8e1d-4a71-89f6-aec418acef67");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Butterfly Sword",
                Description = "This short, single-edged sword typically features a cross guard that helps catch oncoming attacks. It is the preferred weapon of Butterfly Blades—highly skilled Gokan assassins.",
                Price = 20,
                Damage = "1d4",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = WeaponGroups.Instances.Sword.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Disarm.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Monk.ID;
            yield return Traits.Instances.Parry.ID;
            yield return Traits.Instances.Twin.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63775341-f3b9-43bd-bbbc-c395812258d8"),
                SourceId = Pathfinder166.ID,
                Page = 280
            };
        }
    }
}
