using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class Pepperbox : Template
    {
        public static readonly Guid ID = Guid.Parse("773d09ba-aa8a-4171-800f-499732d751b9");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Pepperbox",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5c0628db-1099-4fbc-8e57-3ab875f2dd7b"), "This weapon is a specialty of the smiths of Alkenstar. The pepperbox has three barrels that each hold a single shot, and the shooter can manually rotate the whole barrel assembly to align a loaded barrel with the firing mechanism.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("c1d994f3-083a-4f32-98a1-d566b302d388"),
				Name = "Pepperbox",
				Hands = "1",
				Price = 1200,
				Reload = 1,
				Range = 60,
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c0df83cf-e975-4ab0-8071-45bcd26a4785"), Traits.Instances.Capacity.ID, "3");
            builder.Add(Guid.Parse("ab912a32-31a8-4873-9fb9-d2992b8a8cea"), Traits.Instances.Fatal.ID, "d8"); 
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9596b3b0-f68a-43d9-ad4e-8b3c9cf2d7b3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
