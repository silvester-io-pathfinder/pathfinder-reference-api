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
    public class JugglingClub : Template
    {
        public static readonly Guid ID = Guid.Parse("8a71d87f-4e0a-4041-bb5c-a6902cd161f9");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Juggling Club",
                Description = "A juggling club is lighter than a typical club and balanced to be easily caught and thrown again by a juggler. While a juggling club deals less damage, the extra throwing distance its light weight allows is important for Juggling.",
                Price = 10,
                Damage = "1d4",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Club.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Nonlethal.ID;
            yield return Traits.Instances.Thrown.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a4d437b-b98a-4786-b5cd-9e4fb0899bb5"),
                SourceId = Pathfinder151.ID,
                Page = 77
            };
        }
    }
}
