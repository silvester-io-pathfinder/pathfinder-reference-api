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
    public class TrickyPick : Template
    {
        public static readonly Guid ID = Guid.Parse("c4b2cc2b-36d9-459f-9361-1660a0243944");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Tricky Pick",
                Description = "This ingenious kobold pick conceals several hidden traps, which the wielder can activate to trick and befuddle foes with a variety of damaging blades and bludgeoning surfaces.",
                Price = 1000,
                Damage = "1d6",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = WeaponGroups.Instances.Pick.ID,
                DamageTypeId = Modular.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Backstabber.ID;
            yield return Traits.Instances.Fatal.ID;
            yield return Traits.Instances.Kobold.ID;
            yield return Traits.Instances.Modular.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8bf406fa-0c9f-4013-a491-d0ef11f6cc6e"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
