using Silvester.Pathfinder.Reference.Database.Models.Entities;
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
    public class FireLance : Template
    {
        public static readonly Guid ID = Guid.Parse("b0040f1d-fb5d-4bca-bbb7-a764b1b5cf87");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Fire Lance",
                WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("248f6fea-1338-4597-b99f-c19bb03cad32"), "This amazingly simple projectile weapon is nothing more than a metal tube packed with black powder and a stopper, attached to the sharpened head of a javelin. A loaded fire lance can be wielded as a normal spear, though it requires an Interact action to regrip the weapon and hold it properly when switching from one use to another. Fire lances are most commonly found in Tian Xia, though occasionally one makes its way all the way to Avistan, typically in the hands of a Tien mercenary or caravan guard.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("9fc51b31-ca6c-409a-91d7-aa9e8aa24a2b"),
				Name = "Fire Lance",
				Hands = "2",
				Price = 500,
				Reload = 2,
				Range = 10,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a61c4242-a1a0-4fa6-9090-8bfea0196749"), Traits.Instances.Fatal.ID, "d10"); 
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b98db85-6f7a-4f25-9942-c03636049a14"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
