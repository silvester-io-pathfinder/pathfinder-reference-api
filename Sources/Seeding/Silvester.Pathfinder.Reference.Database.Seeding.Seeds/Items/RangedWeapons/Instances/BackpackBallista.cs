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
    public class BackpackBallista : Template
    {
        public static readonly Guid ID = Guid.Parse("5cf7b30c-f9cd-4748-a40f-3d8d54410233");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Backpack Ballista",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Bow.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c95c27e2-46c7-4fa6-8f9b-4a4757f74d6e"), "This complex wooden device, worn on the back, contains a miniature ballista on a retractable arm. As an Interact action, you can pull a lever to deploy or retract the ballista. As long as it remains deployed, you must hold the ballista using that hand or some of the components spill out onto the ground, just like dropping any other weapon. While deployed, the device opens and raises the ballista up over your shoulder. While retracted, the ballista and its mount slide down and are concealed within the device. Although a backpack ballista packs a punch, the device is a challenge to operate. Reloading it takes 1 minute and can't be done while worn. As normal, you can't wear a backpack ballista with another backpack.");
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("cd24eda2-6ce0-44cb-a185-d8e5fd6c53d7"),
				Name = "Backpack Ballista",
				Hands = "1+",
				Price = 1800,
				Reload = 10,
				Range = 180,
				Damage = "1d12",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f727e3e-01e3-4efc-9977-07d1f49b7469"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 62
            };
        }
    }
}
