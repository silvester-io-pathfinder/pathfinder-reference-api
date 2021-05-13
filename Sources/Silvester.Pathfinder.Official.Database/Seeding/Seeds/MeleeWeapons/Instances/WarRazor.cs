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
    public class WarRazor : Template
    {
        public static readonly Guid ID = Guid.Parse("290046a3-6eac-414f-8374-d046ee27cfe9");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "War Razor",
                Description = "A war razor is an exaggerated version of the barbers’ tool. It is a brittle but extremely sharp weapon that is very easy to slip into a pocket or sleeve.",
                Price = 30,
                Damage = "1d4",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Knife.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Backstabber.ID;
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Finesse.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d6a40c9-a864-4894-8d86-bba7d33c0dce"),
                SourceId = GodsAndMagic.ID,
                Page = 121
            };
        }
    }
}
