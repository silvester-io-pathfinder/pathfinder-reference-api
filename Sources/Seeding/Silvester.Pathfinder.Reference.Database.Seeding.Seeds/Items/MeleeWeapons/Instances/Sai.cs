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
    public class Sai : Template
    {
        public static readonly Guid ID = Guid.Parse("4b438ba2-4e10-4b00-bf4a-7ebb128a26be");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Sai",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("34fb33db-0824-4d42-9a0e-141e611f7373"),
				Name = "Sai",
				Price = 60,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("302781b1-98e6-49b3-ad7d-0050ed80cb09"), "This piercing dagger is a metal spike flanked by a pair of prongs that can be used to trap an enemy's weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2a273589-b01f-4dd9-b099-893fda25a6d5"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("c7ec2744-8199-473c-8d37-edd31455c96e"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("4b5f3e14-0498-445f-bfa0-cd2e8c761aaf"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("62f0043a-5b1e-46ad-9df8-1f16549f6eda"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("62d624e2-4684-4525-83ef-d6ed336119ca"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("657134a7-471f-4562-abc0-2b357b671af0"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cd382d1-77f8-4f36-9ca2-cb1851de819f"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
