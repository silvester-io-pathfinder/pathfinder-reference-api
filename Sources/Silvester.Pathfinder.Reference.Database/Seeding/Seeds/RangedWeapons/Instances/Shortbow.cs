using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ammunitions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RangedWeapons.Instances
{
    public class Shortbow : Template
    {
        public static readonly Guid ID = Guid.Parse("7c36bcfe-e828-43ca-baca-1a49be7ebfba");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Shortbow",
                Description = "This smaller bow is made of a single piece of wood and favored by skirmishers and cavalry.",
                Range = 60,
                Reload = 0,
                Price = 300,
                Damage = "1d6",
                Hands = "1+",
                AmmunitionId = Arrows.ID,
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Bow.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Deadly.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49b660af-5244-401f-8802-973448c4f7bd"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
