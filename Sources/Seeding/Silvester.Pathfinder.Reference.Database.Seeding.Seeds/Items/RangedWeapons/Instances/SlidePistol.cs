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
    public class SlidePistol : Template
    {
        public static readonly Guid ID = Guid.Parse("798b9c67-75e8-4edf-8834-c7cd4ef3deb6");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Slide Pistol",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9963a1f5-2186-4569-a423-48648b3b39a9"), "Also known as a harmonica gun, this weapon is essentially a stock, trigger, and firing mechanism attached to a sliding brace of barrels that can each hold a round of ammunition.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("264dd6e3-fe5a-4fb3-9f43-fa9da308221e"),
				Name = "Slide Pistol",
				Hands = "1",
				Price = 1600,
				Reload = 1,
				Range = 30,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7f91ba98-ea18-4488-9839-53dde6d68bea"), Traits.Instances.Capacity.ID, "5");
            builder.Add(Guid.Parse("28ede4a1-8176-42bb-9f51-3c2e5e699263"), Traits.Instances.Fatal.ID, "d10"); 
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7bbdcad4-bd05-4e01-a29b-56c92a1024ed"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
