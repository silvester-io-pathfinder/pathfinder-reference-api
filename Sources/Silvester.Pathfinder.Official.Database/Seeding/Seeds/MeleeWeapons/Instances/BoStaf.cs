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
    public class BoStaf : Template
    {
        public static readonly Guid ID = Guid.Parse("9966d8d0-e1ae-4e62-9411-988d67474769");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Bo Staf",
                Description = "This strong but slender staff is tapered at the ends and well balanced. It’s designed to be an offensive and defensive weapon.",
                Price = 20,
                Damage = "1d8",
                Hands = "2",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Club.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Monk.ID;
            yield return Traits.Instances.Parry.ID;
            yield return Traits.Instances.Reach.ID;
            yield return Traits.Instances.Trip.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("195ba1fc-dbcf-4884-8d33-b0c40b8c9e42"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
