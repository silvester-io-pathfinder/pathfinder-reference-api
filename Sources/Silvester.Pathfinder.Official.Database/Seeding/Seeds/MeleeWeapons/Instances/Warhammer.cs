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
    public class Warhammer : Template
    {
        public static readonly Guid ID = Guid.Parse("f6497e4f-3dc4-481b-81f6-ffc53c257503");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Warhammer",
                Description = "This weapon has a wooden shaft ending in a large, heavy metal head. The head of the hammer might be single-sided or double-sided, but it’s always capable of delivering powerful bludgeoning blows.",
                Price = 100,
                Damage = "1d8",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Hammer.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Shove.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ca55ad9-67ed-4071-92a1-93b1483ba4fc"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
