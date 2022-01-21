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
    public class Kama : Template
    {
        public static readonly Guid ID = Guid.Parse("bc96e942-df78-4627-8876-f52c0bdb0d17");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Kama",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("b2fd0772-6cc2-47ab-ae35-0ce17ab01048"),
				Name = "Kama",
				Price = 100,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("7d0cc1e6-6048-47b7-8d3c-1ca73849306b"), "Similar to a sickle and used in some regions to reap grain, a kama has a short, slightly curved blade and a wooden handle.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4e34ff46-a802-4787-b2e5-350ae5cee6a0"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("54a9b408-27c3-4756-b6ed-375084e42ae9"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("98b0b9e1-5a4a-407c-badc-ee5d15aef4f9"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("d91eddee-a933-4b45-bcf5-11a6fe91e977"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb2de2e5-441c-4e42-9cd2-0719cba66e57"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
