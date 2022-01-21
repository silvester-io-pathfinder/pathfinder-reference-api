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
    public class Dagger : Template
    {
        public static readonly Guid ID = Guid.Parse("d6be6a4e-d82a-4c7f-adc2-2742b985760d");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Dagger",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("f6764886-e19d-4deb-890b-1cbc0cc80c59"),
				Name = "Dagger",
				Price = 20,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("2031dac2-70c4-4855-841d-97ad6232d414"), "This small, bladed weapon is held in one hand and used to stab a creature in close combat. It can also be thrown.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ebdd747b-987f-418c-b6df-5511dfdd9f31"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("2b561b9f-3c91-4ff6-957a-84f86341102c"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("a692870c-d053-4e38-aaa5-416c1852dca8"), Traits.Instances.Thrown.ID);
            builder.Add(Guid.Parse("f12fb504-6edb-4780-8cd0-a958b2d067fe"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3bc128c1-e633-49fe-959d-23728af2894c"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
