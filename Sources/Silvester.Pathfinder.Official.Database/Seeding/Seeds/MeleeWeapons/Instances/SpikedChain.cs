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
    public class SpikedChain : Template
    {
        public static readonly Guid ID = Guid.Parse("8ada012d-7bc9-4091-8cf7-889d0bbffe7e");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Spiked Chain",
                Description = "This 4‑foot‑long length of chain is covered with barbs and has spikes on one or both ends. Some feature metal hoops used as handgrips.",
                Price = 300,
                Damage = "1d8",
                Hands = "2",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Flail.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disarm.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Trip.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a815cf76-79c0-4130-936c-6468b6cda683"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
