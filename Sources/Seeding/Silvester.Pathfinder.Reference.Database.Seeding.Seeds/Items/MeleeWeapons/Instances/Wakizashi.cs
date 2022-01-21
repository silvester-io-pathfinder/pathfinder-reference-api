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
    public class Wakizashi : Template
    {
        public static readonly Guid ID = Guid.Parse("d3109927-04c6-4ae8-9af1-e661cc2a5440");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Wakizashi",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("c446997d-066b-4c6b-b4c2-744749262c8e"),
				Name = "Wakizashi",
				Price = 100,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("c38bd2b5-91f4-4cc3-bf14-1f863bb97ce2"), "This short-bladed, single-edged sword is typically carried as part of a pair alongside a katana.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4fad1750-b392-45e9-8788-4b7ea4f2d27a"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("00589464-cda2-4654-8f49-46201f1ec5d6"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("3b576b38-8da0-4e75-9c1a-95a3fb1c204a"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("936ff2fc-c736-45b0-9452-d481adc1cb34"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f624693d-be5d-484b-891e-cf1378e1f57a"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ecf6cc9-2fbc-4bfd-adec-6a60538ffe3e"),
                SourceId = CoreRulebook.ID,
                Page = 248
            };
        }
    }
}
