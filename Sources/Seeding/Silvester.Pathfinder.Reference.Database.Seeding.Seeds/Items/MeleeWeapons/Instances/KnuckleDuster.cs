using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class KnuckleDuster : Template
    {
        public static readonly Guid ID = Guid.Parse("5bd963a8-b0cc-405d-b32e-4033d1d363f6");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Knuckle Duster",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Brawling.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("0b2ed073-a48d-4278-8762-81945bdc8d44"),
				Name = "Knuckle Duster",
				Price = 30,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("ddb61f27-c11f-4dd2-9f2b-497c05ba46f0"), "This bit of hardened metal, favored by street toughs, is typically made of brass and features four finger holes so that it can sit atop the knuckles, adding extra power to a punch.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0f0c0d54-d657-4d05-b449-cfd0cfa916a7"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("7b2ff637-af5f-4336-92de-13d888580350"), Traits.Instances.FreeHand.ID);
            builder.Add(Guid.Parse("67d30d2d-71e7-4e52-b71a-bfd6e3e0c2f7"), Traits.Instances.Monk.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec13a470-d6b4-4231-8273-0d434b7e976e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 150
            };
        }
    }
}
