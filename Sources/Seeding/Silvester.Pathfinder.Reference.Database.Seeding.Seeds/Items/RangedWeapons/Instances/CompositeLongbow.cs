using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class CompositeLongbow : Template
    {
        public static readonly Guid ID = Guid.Parse("c532d9bd-cc75-4a16-bb46-b63c06fa9917");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Composite Longbow",
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Bow.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("83a5097c-9a56-484e-af0e-eb184515aae9"), "This projectile weapon is made from horn, wood, and sinew laminated together to increase the power of its pull and the force of its projectile. Like all longbows, its great size also increases the bow's range and power. You must use two hands to fire it, and it cannot be used while mounted. Any time an ability is specifically restricted to a longbow, such as Erastil's favored weapon, it also applies to composite longbows unless otherwise stated.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("828d74ac-41fd-4bf7-a4b2-f9cdd32cd2a8"),
				Name = "Composite Longbow",
				Hands = "1+",
				Price = 2000,
				Reload = 0,
				Range = 100,
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Common.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("12e5e91e-3803-4513-bd6b-d69fc68284de"), Traits.Instances.Deadly.ID, "d10");
            builder.Add(Guid.Parse("7ab36d6b-9cfa-40d7-8d2b-db4a2b2ebe45"), Traits.Instances.Propulsive.ID);
            builder.Add(Guid.Parse("a42032cd-ae71-4b5b-bb2e-ba2ae557b4c3"), Traits.Instances.Volley.ID, "30 ft.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f98fded2-6dfb-43ef-9ef1-2a0b9a9d6dae"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
