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
    public class SwordCane : Template
    {
        public static readonly Guid ID = Guid.Parse("32548452-7334-4260-b729-00272a3bd933");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Sword Cane",
                Description = "This slender, rapier-like sword is concealed within a wooden or metal cane that serves as a sheath, making it an inconspicuous weapon easy to slip past inspections or into high-society events. A sword cane is typically 4 feet long when sheathed, and its hilt is usually capped with a wooden or metal decoration.",
                Price = 500,
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
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a469cd6-e92f-40c6-b7ee-916e412414b3"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 248
            };
        }
    }
}
