using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RangedWeapons.Instances
{
    public class Bola : Template
    {
        public static readonly Guid ID = Guid.Parse("827647a5-7143-4b19-bfee-a974d3636d96");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Bola",
                Description = "This throwing weapon consists of weights tied to the end of long cords, which can be used to bludgeon foes or entangle their legs.",
                Range = 20,
                Price = 50,
                Damage = "1d6",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Sling.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Nonlethal.ID;
            yield return Traits.Instances.RangedTrip.ID;
            yield return Traits.Instances.Thrown.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff4711ed-2ae0-4ec0-bdab-8bbcfb2e2074"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 248
            };
        }
    }
}
