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
    public class Katar : Template
    {
        public static readonly Guid ID = Guid.Parse("6c3223d1-35e9-4273-a384-ffe2ea1b3da3");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Katar",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("f79532a6-07a8-4489-8fe7-34865d82d743"),
				Name = "Katar",
				Price = 30,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("58f6bdce-fe26-46f1-b2dc-291b29559144"), "Also known as punching daggers, katars are characterized by their H-shaped hand grip that allows the blade to jut out from the knuckles.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("53ea2b2a-3635-4a8a-9b87-cbc001ab1ab2"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("f7d9c1f1-5f55-4b8a-8df5-96010e9e221e"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("ea1d6c2b-c782-4fd9-beb5-03dfda2929f3"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("993f748f-a14a-460b-a2f0-58873fa5155f"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("350e2d8b-27a4-4168-88f9-e7cce0ada9d6"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
