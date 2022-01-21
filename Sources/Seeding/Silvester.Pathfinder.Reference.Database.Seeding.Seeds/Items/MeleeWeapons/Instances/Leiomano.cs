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
    public class Leiomano : Template
    {
        public static readonly Guid ID = Guid.Parse("23955b85-8bf5-4f55-81c8-38b19bbf2d8b");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Leiomano",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("6f48c9a6-5d6c-4acf-b5dc-b09437ff1071"),
				Name = "Leiomano",
				Price = 200,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("f9189ab1-9e4f-44e7-b5d9-e5e2eac1ac19"), "This thick club is inset with sharp teeth, typically from a shark, that easily tear flesh. It is the preferred weapon of many Minatan warriors.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f4604f65-6d60-4cdf-8baa-6f22387d1c3b"), Traits.Instances.Deadly.ID, "d10");
            builder.Add(Guid.Parse("c50a21ad-a791-43ad-ad4a-8891fea7b9ef"), Traits.Instances.Versatile.ID, "S");
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ab7163c-62ce-4d66-8d0a-6c73039db764"),
                SourceId = Sources.Instances.Pathfinder166.ID,
                Page = 76
            };
        }
    }
}
