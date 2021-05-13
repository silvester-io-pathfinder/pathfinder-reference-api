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
    public class Rungu : Template
    {
        public static readonly Guid ID = Guid.Parse("361b69e6-127f-4c0b-8a0a-b15f63778a76");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Rungu",
                Description = "This specialized club is designed for throwing and is useful for both combat and hunting. Though gripplis didn't create the rungu originally, many grippli communities have adopted it as the weapon of choice for hunting creatures that hide high in treetops.",
                Price = 40,
                Damage = "1d6",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Club.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Grippli.ID;
            yield return Traits.Instances.Shove.ID;
            yield return Traits.Instances.Thrown.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bb96701-ea4f-4e80-a828-fb86b3c81e4b"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
