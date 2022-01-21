using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class DoubleBarreledMusket : Template
    {
        public static readonly Guid ID = Guid.Parse("ce088a24-9f14-4ac1-a69e-b99d88210fa8");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Double-Barreled Musket",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("434276f7-6162-4e80-8346-187baeabfca9"), "This flintlock breech-loader has two side-by-side barrels. Though less accurate than a standard musket, a double-barreled musket offers versatility in firing options. Many of Alkenstar�s famous shield marshals save their earnings to buy a double-barreled musket as their first personal firearm.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("51159d26-00a3-4af1-b5bf-f1acb0b1ef2c"),
				Name = "Double-Barreled Musket",
				Hands = "2",
				Price = 1100,
				Reload = 1,
				Range = 60,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6639b6b6-3941-4b5d-83b3-16bce95d621c"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("5784c1dd-35cb-41e1-b4ea-37071f6dc22b"), Traits.Instances.DoubleBarrel.ID);
            builder.Add(Guid.Parse("ee8688d9-526b-4843-92b9-8b984ee59eeb"), Traits.Instances.Fatal.ID, "d10");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e35e607c-ed56-4e8c-abf0-8b38edf41d1a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
