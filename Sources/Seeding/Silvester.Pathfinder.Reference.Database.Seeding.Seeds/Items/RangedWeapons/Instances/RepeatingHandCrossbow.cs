using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
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
    public class RepeatingHandCrossbow : Template
    {
        public static readonly Guid ID = Guid.Parse("c5272f9b-93f4-42d6-baa1-7262fb6cd1ec");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Repeating Hand Crossbow",
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = Bow.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("43b7f3d5-09f0-4617-9902-94859f78222b"), "This weapon features an ingeniously designed catch mechanism at the top of the flight grove, just in front of the latch, which automatically loads a bolt from a magazine and resets the string each time the weapon is fired. A typical repeating hand crossbow magazine holds five bolts.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("0f76e5d4-2fd0-426e-a0ff-d8e6dd695b5f"),
				Name = "Repeating Hand Crossbow",
				Hands = "1",
                Price = 1000,
				Reload = 0,
				Range = 60,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b1911260-a0fa-474c-bb7b-b35ef0281ac6"), Traits.Instances.Repeating.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f97d2f26-6130-4d23-aac8-015e07958054"),
                SourceId = Pathfinder165.ID,
                Page = 73
            };
        }
    }
}
