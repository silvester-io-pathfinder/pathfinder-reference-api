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
    public class ExquisiteSwordCane : Template
    {
        public static readonly Guid ID = Guid.Parse("8d2cf9bb-b236-417e-84b3-3710d02c6dbf");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Exquisite Sword Cane",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("07fc1d6a-4d5b-41f8-834e-8ff7481412f8"),
				Name = "Exquisite Sword Cane",
				Price = 9000,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("131df0c4-e4f1-4d80-85e4-0a3fdfc93344"), "An exquisite sword cane is a sword sheathed inside a hollow cane, which itself can be used as a clubbing weapon with or without the sword sheathed inside.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("04db2959-a0d8-4113-94fe-a9d19ddabaa8"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("86f7a61a-fb11-4e10-99d4-90a9bf0b2287"), Traits.Instances.Concealable.ID);
            builder.Add(Guid.Parse("31e142d8-f7ec-4013-85f9-f464a776c6aa"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("c50c08f7-0747-48df-a6f3-e1ecc6e7443b"), Traits.Instances.Parry.ID);
            builder.Add(Guid.Parse("68324b46-8989-4ee8-bab7-489b12280e96"), Traits.Instances.Twin.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c084b21a-06ee-4bc2-b30a-ac60369c99c1"),
                SourceId = Pathfinder157.ID,
                Page = 80
            };
        }
    }
}
