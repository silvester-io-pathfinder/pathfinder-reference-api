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
    public class GillHook : Template
    {
        public static readonly Guid ID = Guid.Parse("8f28ae9d-f0a6-4ed9-af09-e44de58acd82");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Gill Hook",
                Description = "This spear has a specialized hook just before the tip that can catch on the gills of large fish. Azarketis primarily use this to hunt sharks, but it can also be used to hook flesh or armor. This weapon is common on the Isle of Kortos and within azarketi settlements.",
                Price = 200,
                Damage = "1d10",
                Hands = "2",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Spear.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Azarketi.ID;
            yield return Traits.Instances.Grapple.ID;
            yield return Traits.Instances.Reach.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd53aa21-92e7-4268-ad3a-76d4d3f48290"),
                SourceId = AzarketiAncestryWebSupplement.ID,
                Page = 1
            };
        }
    }
}
