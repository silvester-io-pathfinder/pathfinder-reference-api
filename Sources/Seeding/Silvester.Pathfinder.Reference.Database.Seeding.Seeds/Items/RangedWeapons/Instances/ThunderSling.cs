using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class ThunderSling : Template
    {
        public static readonly Guid ID = Guid.Parse("2681245d-4754-4426-be9e-34d7ba96128f");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Thunder Sling",
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Sling.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("183e60bd-9439-4089-8e42-dd60f76eb424"), "Tengu use these specialized slings to fire darts further and with greater force than when thrown by hand, which is particularly effective when attacking from great heights. A thunder sling uses darts as ammunition. It can also hurl blowgun darts as ammunition but deals 1d4 piercing damage instead of 1d6 when used this way.");;
        }
                
        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("700653db-2cca-4171-8aa1-1c9ec49bdc76"),
				Name = "Thunder Sling",
				Hands = "1",
				Price = 500,
				Reload = 1,
				Range = 50,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("89d85198-2051-42e8-b184-033c272bc213"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("eb376c68-9099-4f47-8b47-f564faeee5e9"), Traits.Instances.Propulsive.ID);
            builder.Add(Guid.Parse("026c4771-1045-4578-bfd8-0ba011adfd7e"), Traits.Instances.Tengu.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2523e56-dad3-4c5c-8787-4b13ab0c823a"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
