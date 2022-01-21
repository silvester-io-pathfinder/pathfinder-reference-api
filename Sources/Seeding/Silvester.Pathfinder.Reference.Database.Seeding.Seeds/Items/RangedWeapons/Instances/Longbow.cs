using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class Longbow : Template
    {
        public static readonly Guid ID = Guid.Parse("59fa141b-7ef8-4ae5-b006-925a1a5e4fc3");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Longbow",
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Bow.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("78e6d98c-e140-4f3f-a135-67bef1fb0523"), "This 5-foot-tall bow, usually made of a single piece of elm, hickory, or yew, has a powerful draw and is excellent at propelling arrows with great force and at an extreme distance. You must use two hands to fire a longbow, and it can't be used while mounted.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("4f1e954f-fe55-49d5-b8fb-68ac9d049182"),
				Name = "Longbow",
				Hands = "1+",
				Price = 600,
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
            builder.Add(Guid.Parse("8ecc2cef-02b9-4578-84c0-be256ac2356d"), Traits.Instances.Deadly.ID, "d10");
            builder.Add(Guid.Parse("10c52ab9-0541-48be-9003-c3fe0f3d6bbc"), Traits.Instances.Volley.ID, "30ft");
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
