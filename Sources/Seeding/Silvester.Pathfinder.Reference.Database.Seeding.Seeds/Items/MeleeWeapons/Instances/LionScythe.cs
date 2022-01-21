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
    public class LionScythe : Template
    {
        public static readonly Guid ID = Guid.Parse("a198604c-ca18-4507-bec4-ee0f637fe1cf");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Lion Scythe",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("1dd9f726-8193-4b6b-98e8-783b8de1cb71"),
				Name = "Lion Scythe",
				Price = 100,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("c77ecc35-b560-49c8-8afe-19186b041ef8"), "A lion scythe resembles a common sickle but is specially weighted to allow for greater power when attacking. This is a martial melee weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("48093052-60ab-466b-9fd8-a3da1d919893"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("909e049e-74ae-40be-93e5-b53978ad9107"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("8b7579c7-10d9-4b89-9152-9ef30f391f45"), Traits.Instances.Trip.ID);
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fec2d265-12e5-402c-a121-43f165201802"),
                SourceId = Sources.Instances.Pathfinder172.ID,
                Page = 78
            };
        }
    }
}
