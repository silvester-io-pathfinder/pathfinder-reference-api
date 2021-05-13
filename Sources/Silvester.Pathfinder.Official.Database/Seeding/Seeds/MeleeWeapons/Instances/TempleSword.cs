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
    public class TempleSword : Template
    {
        public static readonly Guid ID = Guid.Parse("a460d789-3935-4629-a976-f9b71d96181c");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Temple Sword",
                Description = "This heavy blade is favored by guardians of religious sites. It has a distinctive, crescent-shaped blade that seems to be a mix of a sickle and sword. It often has holes drilled into the blade or the pommel so that bells or other holy trinkets can be affixed to the weapon as an aid for prayer or mediation.",
                Price = 200,
                Damage = "1d8",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Monk.ID;
            yield return Traits.Instances.Trip.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("210b63cd-cf1e-401e-9166-893d1b8bfb09"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
