using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class Sling : Template
    {
        public static readonly Guid ID = Guid.Parse("26d5e7ba-84a2-46d5-966d-c8eeda6cf9a4");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Sling",
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Sling.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7ad1cd38-59e9-40c1-a13f-8051b9813d8f"), "Little more than a leather cup attached to a pair of straps, a sling can be used to fling smooth stones or sling bullets at a range.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("167fefde-f423-4c41-b4df-8f47194e74a4"),
				Name = "Sling",
				Hands = "1",
				Price = 0,
				Reload = 1,
				Range = 50,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				RarityId = Rarities.Instances.Common.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("728ac79f-b0c9-4df8-806f-0fefab1d99b1"), Traits.Instances.Propulsive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95ea6700-cabd-4454-8926-4e4a75a55b59"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
