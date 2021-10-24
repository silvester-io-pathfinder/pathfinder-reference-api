using Silvester.Pathfinder.Reference.Database.Models.Entities;
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
    public class HeavyCrossbow : Template
    {
        public static readonly Guid ID = Guid.Parse("4db58af2-e60f-44f7-b8b3-88a1a74c3120");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Heavy Crossbow",
                Description = "This large crossbow is harder to load and more substantial than a regular crossbow, but it packs a greater punch.",
                Range = 120,
                Reload = 2,
                Price = 400,
                Damage = "1d10",
                Hands = "2",
                AmmunitionId = Bolts.ID,
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = Bow.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6cafd971-2575-43f8-861b-9c1024a3ac11"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
