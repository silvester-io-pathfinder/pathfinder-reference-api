using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
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
    public class HalflingSlingStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("957a55d1-dbc4-4060-ac98-aa4523175510");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Halfling Sling Staff",
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Sling.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f5541d5a-3908-43fa-b14d-38ab5c09282d"), "This staff ends in a Y-shaped split that cradles a sling. The length of the staff provides excellent leverage when used two‑handed to fling rocks or bullets from the sling.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("0a05e986-a0dc-4af8-8b63-47fb6ff27ef3"),
				Name = "Halfling Sling Staff",
				Hands = "2",
				Price = 500,
				Reload = 1,
				Range = 80,
				Damage = "1d10",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9d712239-2063-42da-9cac-66d7fc1ce72f"), Traits.Instances.Halfling.ID);
            builder.Add(Guid.Parse("f7295ca7-b82b-46da-aa68-2fd35e51309d"), Traits.Instances.Propulsive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd06d5ba-e50c-461f-ac71-3271d52c9c3f"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
