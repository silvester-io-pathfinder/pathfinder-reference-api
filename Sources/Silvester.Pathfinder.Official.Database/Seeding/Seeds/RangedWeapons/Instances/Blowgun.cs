using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Ammunitions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RangedWeapons.Instances
{
    public class Blowgun : AbstractRangedWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("f7462ef0-62d3-48ad-bc24-e80318b98455");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Blowgun",
                Description = "This long, narrow tube is used for shooting blowgun darts, using only the power of a forcefully exhaled breath.",
                Range = 20,
                Reload = 1,
                Price = 10,
                Damage = "1",
                Hands = "1",
                AmmunitionId = BlowgunDarts.ID,
                BulkId = LightBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = Dart.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Nonlethal.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00860b13-76fc-42d7-a5d7-00a6591e21dc"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
