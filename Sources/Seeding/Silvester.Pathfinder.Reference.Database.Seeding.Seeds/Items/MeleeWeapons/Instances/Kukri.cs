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
    public class Kukri : Template
    {
        public static readonly Guid ID = Guid.Parse("3a7317bb-6d6a-47b0-8c99-6ac442e23675");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Kukri",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("f41c0bc5-406e-4e9d-aafc-43339c8a5879"),
				Name = "Kukri",
				Price = 60,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("74f41916-ee29-4604-8a05-8dec32e689e3"), "The blade of this foot-long knife curves inward and lacks a cross guard at the hilt.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e1344dd9-98bc-4563-9976-eaa2b3173138"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("6e2b17a6-b737-498f-b4c5-1400152e9a52"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("6f6fd7ee-d672-4418-b380-dafac2a0cfd3"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("ca7a5707-216c-4c41-bbea-882d18ee1185"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c659544-3faf-45d2-be68-df7b72a97005"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
