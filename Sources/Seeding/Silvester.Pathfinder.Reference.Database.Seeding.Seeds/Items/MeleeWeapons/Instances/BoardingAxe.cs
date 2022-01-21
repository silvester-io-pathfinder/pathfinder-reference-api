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
    public class BoardingAxe : Template
    {
        public static readonly Guid ID = Guid.Parse("f7b0c42c-87a4-45eb-8de6-12ca3fe71780");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Boarding Axe",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Axe.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("27e46575-377e-43ea-b397-5ed69a77bde6"),
				Name = "Boarding Axe",
				Price = 100,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("d006dc0b-7f08-4479-a8ef-2e653cb4f87b"), "This small axe sports a spike opposite the blade that aids in climbing and is useful in clearing obstacles, such as fallen rigging. This weapon is common in the High Seas region, on the Isle of Kortos and within azarketi settlements.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6e27fd9d-bd55-45ad-89a3-1c9d9ce5ce11"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("a74d24e8-4c4e-4239-bf0e-553cd7baf51c"), Traits.Instances.Azarketi.ID);
            builder.Add(Guid.Parse("4c751595-5a89-40b9-a588-5f9773371163"), Traits.Instances.Climbing.ID);
            builder.Add(Guid.Parse("3f091744-7f40-4a17-be4f-d884e329e0a7"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("c8eb3e65-2921-44a4-9e6d-1d38553f20db"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e677da1c-767e-4a45-9b62-af9984d2fa85"),
                SourceId = AzarketiAncestryWebSupplement.ID,
                Page = 1
            };
        }
    }
}
