using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class Nunchaku : Template
    {
        public static readonly Guid ID = Guid.Parse("d1ad3308-48ce-4720-8d53-b1152ac0592f");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Nunchaku",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("2b3525b1-28ba-4572-bc90-175909c91e6d"),
				Name = "Nunchaku",
				Price = 20,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("1d2ce96d-285c-40b5-9dd4-b3460bbb8792"), "The nunchaku is constructed of two wooden or metal bars connected by a short length of rope or chain.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1bc14f75-e20c-4814-9883-6530e73d0223"), Traits.Instances.Backswing.ID);
            builder.Add(Guid.Parse("22e81bed-23a6-4c82-9fa1-5f28fa569ed3"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("b9e40e8d-190e-4a83-865c-22c32f9ffe03"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("1f8e371e-2bc4-4fe7-8efc-f3172c957ab6"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("ac20861c-f948-4253-b03c-fd864c561ee2"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c957e89f-fb12-4dd2-a925-d5e7cb81e922"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
