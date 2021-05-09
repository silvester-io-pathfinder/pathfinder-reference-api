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
    public class ExquisiteSwordCane : AbstractMeleeWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("8d2cf9bb-b236-417e-84b3-3710d02c6dbf");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Exquisite Sword Cane",
                Description = "An exquisite sword cane is a sword sheathed inside a hollow cane, which itself can be used as a clubbing weapon with or without the sword sheathed inside.",
                Level = 4,
                Price = 9000,
                Damage = "1d6",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Concealable.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Parry.ID;
            yield return Traits.Instances.Twin.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c084b21a-06ee-4bc2-b30a-ac60369c99c1"),
                SourceId = Pathfinder157.ID,
                Page = 80
            };
        }
    }
}
