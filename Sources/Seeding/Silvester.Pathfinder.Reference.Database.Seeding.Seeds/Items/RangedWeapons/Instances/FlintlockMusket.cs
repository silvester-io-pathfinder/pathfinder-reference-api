using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class FlintlockMusket : Template
    {
        public static readonly Guid ID = Guid.Parse("b12a365d-a09a-4a3c-bad4-e38adfe27267");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Flintlock Musket",
                WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a1cd003f-382c-40e8-9096-688823dd2391"), "The most commonly available of firearms in Alkenstar, the flintlock musket includes an external firing mechanism and an efficient and relatively compact frame. Though lacking the range and firing power of the arquebus preferred by Alkenstar and Dongun Hold�s military members, the flintlock musket is popular among civilians for its ease of use.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("665e9ef8-88b2-4a52-aec9-4b850f7583fd"),
				Name = "Flintlock Musket",
				Hands = "2",
				Price = 700,
				Reload = 1,
				Range = 70,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("68e3e438-a8b4-4e79-8dda-5e2607ed78f5"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("6d4a1238-6ced-42f8-bb07-8b6dfbe808aa"), Traits.Instances.Fatal.ID, "d10");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84fbe132-b3d4-4fc4-9425-141a9d894a5a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
