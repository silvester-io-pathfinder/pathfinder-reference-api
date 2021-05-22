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
    public class Fauchard : Template
    {
        public static readonly Guid ID = Guid.Parse("875d97cc-2d8f-4498-8659-00251e3f969c");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Fauchard",
                Description = "A fauchard is similar to a glaive, save that its cutting edge is along the concave side. Fauchards are favored by Crimson Reclaimers for hacking through waves of zombies. The fauchard is a martial melee weapon.",
                Price = 100,
                Damage = "1d8",
                Hands = "2",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Polearm.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Reach.ID;
            yield return Traits.Instances.Sweep.ID;
            yield return Traits.Instances.Trip.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2084884d-e0ed-4656-ab81-14730a7d2607"),
                SourceId = CharacterGuide.ID,
                Page = 92
            };
        }
    }
}
