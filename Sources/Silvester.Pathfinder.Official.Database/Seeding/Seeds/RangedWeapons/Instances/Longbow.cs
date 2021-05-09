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
    public class Longbow : AbstractRangedWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("59fa141b-7ef8-4ae5-b006-925a1a5e4fc3");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Longbow",
                Description = "This 5-foot-tall bow, usually made of a single piece of elm, hickory, or yew, has a powerful draw and is excellent at propelling arrows with great force and at an extreme distance. You must use two hands to fire a longbow, and it can’t be used while mounted.",
                Range = 100,
                Reload = 0,
                Price = 600,
                Damage = "1d8",
                Hands = "1+",
                AmmunitionId = Arrows.ID,
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Bow.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Volley.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef9133cf-1818-4e73-9608-d3ed4c5cc288"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
