using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RangedWeapons.Instances
{
    public class Daikyu : Template
    {
        public static readonly Guid ID = Guid.Parse("97d36556-d936-4a4e-a9cb-3ec41cd816aa");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Daikyu",
                Description = "This asymmetrical bow, made of laminated bamboo, wood, and leather, stands 6 feet or more in height. Using a daikyu while mounted limits its firing range to your left side.",
                Range = 80,
                Price = 800,
                Damage = "1d8",
                Hands = "1+",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = Bow.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c9fc2c3-4682-4a38-9585-e3412fee32e2"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 248
            };
        }
    }
}
