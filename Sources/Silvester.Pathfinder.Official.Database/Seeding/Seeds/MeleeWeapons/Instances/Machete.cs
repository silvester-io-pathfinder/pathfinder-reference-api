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
    public class Machete : Template
    {
        public static readonly Guid ID = Guid.Parse("afd07976-4043-4ab6-a964-43725fc49c3f");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Machete",
                Description = "This medium-length sword has a wide blade and long grip. Though it is typically used to hack through heavy foliage, the machete can also be used as a deadly weapon.",
                Price = 70,
                Damage = "1d6",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Sweep.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("417e54fd-71ac-4621-83da-f139118aa46b"),
                SourceId = GodsAndMagic.ID,
                Page = 120
            };
        }
    }
}
