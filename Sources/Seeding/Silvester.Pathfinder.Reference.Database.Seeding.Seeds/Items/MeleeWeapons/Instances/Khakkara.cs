using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class Khakkara : Template
    {
        public static readonly Guid ID = Guid.Parse("50de7f64-76a6-4bf0-9d0e-0b57aea3ba85");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Khakkara",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("f5ccf543-b11f-4625-90ec-5998f90e1d0c"),
				Name = "Khakkara",
				Price = 200,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("1fe96497-04d8-45f7-8621-a93b0d1e2d2d"), "This staff is topped by a pointed metal circle from which hang several smaller rings that jingle and clang noisily as the staff is moved, allowing you to announce your presence and scare off wild animals as you walk.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f5207af0-6838-4ee7-b05a-25429162ea71"), Traits.Instances.Shove.ID);
            builder.Add(Guid.Parse("6c083633-fb2f-4d01-9b80-ced6e5efacff"), Traits.Instances.TwoHand.ID);
            builder.Add(Guid.Parse("0bdff93b-9301-4e9d-a5e5-ec906ac71155"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ed4dda16-8787-4980-a74d-a4e9b86cc0ac"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b0e10a8-cc3f-4639-b945-72c60f05bf5c"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 248
            };
        }
    }
}
