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
    public class LongAirRepeater : Template
    {
        public static readonly Guid ID = Guid.Parse("077829c6-a7d1-4645-a719-e69a8c77995d");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Long Air Repeater",
                WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d5c9f773-df1d-4e88-bada-ef85aa4f3d59"), "Like the one-handed air repeater, this thin-barreled firearm uses a container of pressurized air instead of black powder to propel small metal pellets from an attached cartridge. The long air repeater has better range and ammo capacity than the one-handed variant, though it still lacks significant stopping power. A typical long air repeater magazine holds 8 pellets.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("e548252e-9a0b-46c7-a67a-8c0dbdade52d"),
				Name = "Long Air Repeater",
				Hands = "1",
				Price = 900,
				Reload = 0,
				Range = 60,
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("10a38220-405e-4dcb-8eb3-12ee8be94de9"), Traits.Instances.Repeating.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a63d6af-c738-42f6-93ae-ea354ea7b33d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
