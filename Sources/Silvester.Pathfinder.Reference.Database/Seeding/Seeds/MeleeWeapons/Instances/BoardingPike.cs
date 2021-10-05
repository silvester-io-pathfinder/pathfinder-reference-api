using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class BoardingPike : Template
    {
        public static readonly Guid ID = Guid.Parse("c0c4e1e1-fc1c-4a9e-8797-8f2eabaeec50");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Boarding Pike",
                Description = "Taking the form of a longspear fitted with crossbars or hooks, a boarding pike provides its wielder a sharp implement that's as adept at shoving enemies off a ship's railings as facilitating the boarding of other vessels. This is a martial melee weapon.",
                Level = 1,
                Price = 80,
                Damage = "1d10",
                Hands = "2",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Polearm.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Reach.ID;
            yield return Traits.Instances.Shove.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa76307d-e009-4ee4-96a5-17aa0bbfa921"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 80
            };
        }
    }
}
