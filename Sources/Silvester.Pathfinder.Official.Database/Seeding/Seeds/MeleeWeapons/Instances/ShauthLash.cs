using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class ShauthLash : Template
    {
        public static readonly Guid ID = Guid.Parse("fdd7f7db-241e-4d1c-bc53-7b280dc679f1");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Shauth Lash",
                Description = "This metal chain bears hook-like barbs made of alchemically strengthened urdefhan teeth. Magical shauth lashes have the same ability to channel an urdefhan wielder's Wicked Bite as magical shauth blades, and urdefhans hold these weapons with the same reverence as they do shauth blades.",
                Price = 800,
                Damage = "1d6",
                Hands = "2",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = WeaponGroups.Instances.Flail.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Trip.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a764b309-d1f9-4236-9c0f-cc9d74c262d9"),
                SourceId = Pathfinder165.ID,
                Page = 73
            };
        }
    }
}
