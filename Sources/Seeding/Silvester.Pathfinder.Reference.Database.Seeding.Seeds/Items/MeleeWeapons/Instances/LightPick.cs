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
    public class LightPick : Template
    {
        public static readonly Guid ID = Guid.Parse("c723e7e5-5ee2-42c8-9aa8-3611cb1d5075");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Light Pick",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Pick.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("04f583cf-2f6d-466e-ac4c-1b4c1ee8b6d0"),
				Name = "Light Pick",
				Price = 40,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("03917a66-867d-4712-a1fb-613b051cf091"), "A light pick is a modified mining implement with a wooden shaft ending in a pick head crafted more to pierce armor and flesh than chip rocks.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d844d0e5-4712-4208-83f2-d0a6d3d88bdb"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("8269968e-7f16-40be-9c53-c91212d14b58"), Traits.Instances.Fatal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("867acff8-88aa-4b8c-a9a0-22f60ce34c83"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
