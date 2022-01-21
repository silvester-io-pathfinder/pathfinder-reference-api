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
    public class Horsechopper : Template
    {
        public static readonly Guid ID = Guid.Parse("c3d2c58d-904d-4fb5-9246-bc292a95ba8e");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Horsechopper",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Polearm.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("339caaa6-4224-4b2a-881a-89591180d15f"),
				Name = "Horsechopper",
				Price = 90,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("581ef6a8-6cde-476b-8960-1484bc1c05f7"), "Created by goblins to battle horses, this weapon is essentially a long shaft ending in a blade with a large hook.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("21042430-b030-4fd5-b7d2-dfefdd45c76b"), Traits.Instances.Goblin.ID);
            builder.Add(Guid.Parse("3379c51a-c524-451f-9817-3811ac69434d"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("656d7814-b81f-42e7-b2f0-0871221b21a1"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("e0ca85ba-ac13-4581-9ff8-3b7c7d292c15"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("99971d0d-3d2f-4ea7-a7c7-80bcdc528612"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bde76d4-71e5-40d2-994e-473c24c1f2d5"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
