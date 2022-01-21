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
    public class JugglingClub : Template
    {
        public static readonly Guid ID = Guid.Parse("8a71d87f-4e0a-4041-bb5c-a6902cd161f9");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Juggling Club",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("538f8d17-7d02-4b25-b21d-558f3aa26d79"),
				Name = "Juggling Club",
				Price = 10,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("1173cad8-7bee-4390-b84d-2825e4579384"), "A juggling club is lighter than a typical club and balanced to be easily caught and thrown again by a juggler. While a juggling club deals less damage, the extra throwing distance its light weight allows is important for Juggling.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("92eafe33-7d5f-47db-8f6b-2b1269c35c22"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("33c4f48e-7536-4675-980f-1892b56e3793"), Traits.Instances.Nonlethal.ID);
            builder.Add(Guid.Parse("3c43a866-d9ea-4965-82e4-05f78c6039af"), Traits.Instances.Thrown.ID);
            builder.Add(Guid.Parse("427d122f-bc4b-4de1-97bf-b4d54b187dc7"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a4d437b-b98a-4786-b5cd-9e4fb0899bb5"),
                SourceId = Pathfinder151.ID,
                Page = 77
            };
        }
    }
}
