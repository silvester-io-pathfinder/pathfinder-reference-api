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
    public class Kusarigama : Template
    {
        public static readonly Guid ID = Guid.Parse("a51af845-2603-4824-bf0d-32a4f9df2621");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Kusarigama",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("375537b2-6a54-4f12-b84b-dba3b6c096ad"),
				Name = "Kusarigama",
				Price = 200,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("6e0fbcdd-2298-4e19-a7e6-24a06388a6ba"), "This impressive weapon consists of a weight attached to a kama via a length of chain, which aids with disarming an opponent or attacking from a distance.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("74ad8be8-5430-43b0-82d5-1373032b3549"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("a2e0ae80-4fc5-4436-817b-77e65bd9faa5"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("958d6130-bdb9-4f03-933d-5fc5045f32d7"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("d397b02e-2c6e-4a3d-813a-6c0c519ed9b4"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("db967899-6fe0-45eb-89c8-207faaae4462"), Traits.Instances.Versatile.ID, "B");
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b890a90-f5df-4750-be6b-ba9d9a040995"),
                SourceId = Sources.Instances.Pathfinder166.ID,
                Page = 76
            };
        }
    }
}
