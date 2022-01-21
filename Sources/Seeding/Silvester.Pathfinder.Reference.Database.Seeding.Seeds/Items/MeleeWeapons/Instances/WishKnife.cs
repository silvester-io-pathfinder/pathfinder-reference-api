using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class WishKnife : Template
    {
        public static readonly Guid ID = Guid.Parse("db430363-1e76-4b5c-ae80-8eae469a2fed");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Wish Knife",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("e2ec8cd0-76ec-4312-b81d-b89ddf2864df"),
				Name = "Wish Knife",
				Price = 200,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("577005a0-f9b0-4e82-8b56-ed04ffa62d62"), "Much like a wish blade, the length of this knife is scored with intricate grooves capable of retaining energy. Wish knives are lighter than their counterparts, making them the weapon of choice for agile combatants.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c79004a0-2b0f-49c0-bfdc-c4536a011ae4"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("5a4877d1-2eb1-4e65-9c90-93882b016102"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("5b92fc36-cc7a-47f0-9569-cfd609e91c47"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("ba4df15c-9c42-405f-9302-8f9465eb2980"), Traits.Instances.Geniekin.ID);
            builder.Add(Guid.Parse("27824119-2255-4585-909e-4a194322a242"), Traits.Instances.Resonant.ID);
            builder.Add(Guid.Parse("b76122ac-00ae-4403-9c20-80a5e1d06a64"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("07ab6734-5e56-4280-bd0a-30349539875e"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1b09e15-ee47-4679-9b16-bb1a07a98e8b"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
