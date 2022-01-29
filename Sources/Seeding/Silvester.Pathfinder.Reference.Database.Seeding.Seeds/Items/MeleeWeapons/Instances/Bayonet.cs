using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class Bayonet : Template
    {
        public static readonly Guid ID = Guid.Parse("fc31569c-bcac-4850-9661-cd3dd65b1041");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Bayonet",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("e0801a89-8d39-4697-9d17-185b6e445dd2"),
				Name = "Bayonet",
				Price = 20,
				Hands = "1 or 2.",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("4c8ce708-18c8-4b45-bbba-94f25e38f6ee"), "This blade or spike can be attached to a crossbow or firearm but, unlike other attached weapons, can be wielded in one hand as its own weapon. When used as a separate weapon, it can't benefit from any runes or abilities that function only for attached weapons.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3595dc35-2e3c-4f08-9aa3-a14d0d494941"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("59d67542-8bf4-4127-8a82-2cfe6a130f74"), Traits.Instances.Attached.ID);
            builder.Add(Guid.Parse("0ad9f8b9-1bfa-4e35-88be-5b236e6945fc"), Traits.Instances.Finesse.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9332ea99-01f6-435e-bdf1-1be4306348dd"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 150
            };
        }
    }
}
