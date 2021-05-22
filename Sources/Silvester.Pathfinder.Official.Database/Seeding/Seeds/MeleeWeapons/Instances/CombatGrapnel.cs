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
    public class CombatGrapnel : Template
    {
        public static readonly Guid ID = Guid.Parse("6a5291fb-45dc-426b-8605-d808c123759c");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Combat Grapnel",
                Description = "Although grappling hooks typically serve as a climbing tool, this specially reinforced grapnel attached to a rope up to 10 feet long can be swung as a weapon. This is a martial melee weapon.",
                Level = 1,
                Price = 90,
                Damage = "1d6",
                Hands = "2",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Flail.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Grapple.ID;
            yield return Traits.Instances.Tethered.ID;
            yield return Traits.Instances.Thrown.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53c212b5-cb72-4f75-a597-98bdd4181af0"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 80
            };
        }
    }
}
