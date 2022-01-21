using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class WishBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("d9ea2c6f-772e-455e-8cf3-dd6c5961ed06");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Wish Blade",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("58ac9c45-68b9-4354-a7eb-7d97c0f1a617"),
				Name = "Wish Blade",
				Price = 500,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("74228ad8-91c6-4e61-b4c9-21b5c5f7bb2f"), "Specialized grooves lined with unique, alchemically treated metals capable of retaining energy score the length of this sword. The first wish blades originated from genie smiths, and the knowledge of these weapons has been passed on to generations of geniekin, earning them the name wish blades.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("55c4416a-d68f-4f28-9465-8e94a54406f5"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("4bffd613-512e-4288-9b1e-9bc75d1c83a6"), Traits.Instances.Geniekin.ID);
            builder.Add(Guid.Parse("0abe1d65-d0e5-4c9b-9f9b-7440570671c7"), Traits.Instances.Resonant.ID);
            builder.Add(Guid.Parse("5a74d7ff-359c-4370-8c85-34020fc8c223"), Traits.Instances.TwoHand.ID);
            builder.Add(Guid.Parse("398e254d-2433-4e9a-9a74-004a5e36a3f6"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64f89b92-6a27-440a-9715-521682b5b35e"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
