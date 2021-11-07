using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class NineRingSword : Template
    {
        public static readonly Guid ID = Guid.Parse("46dd2003-0ce1-492c-955b-508b574c4097");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Nine-Ring Sword",
                Description = "This sword has a broad blade, along which are threaded nine heavy metal rings. The rings add weight to the weapon for downward swings, as well as clashing together to make noise.",
                Price = 90,
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
            yield return Traits.Instances.Disarm.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("468fdb16-f40a-42fc-9956-77e507fd805e"),
                SourceId = LostOmensGodsAndMagic.ID,
                Page = 121
            };
        }
    }
}
