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
    public class StilettoPen : Template
    {
        public static readonly Guid ID = Guid.Parse("3f47473d-20b7-44af-89d7-0b09b74e0665");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Stiletto Pen",
                Description = "This weapon is a fully functional, lavish ink pen with a clip that can be attached to a pocket or bandoleer and easily retrieved as a free action. Using an action to Interact with the pen allows its wielder to disengage a stiletto blade that slides free of the upper body or reattach the previously removed blade.",
                Level = 1,
                Price = 800,
                Damage = "1d4",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Dart.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Concealable.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Thrown.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83d1411d-23e1-4926-abd0-aa4ab8667b0c"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 30
            };
        }
    }
}
