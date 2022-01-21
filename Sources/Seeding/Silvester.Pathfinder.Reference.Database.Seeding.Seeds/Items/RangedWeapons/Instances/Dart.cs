using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class Dart : Template
    {
        public static readonly Guid ID = Guid.Parse("97e3f8ff-014b-4f9f-9a6a-a33a0584f7b8");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Dart",
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Dart.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1cd2621a-4f2f-406a-b2e3-bd5c33e13f91"), "This thrown weapon is larger than an arrow but shorter than a javelin. It typically has a short shaft of wood ending in a metal tip and is sometimes stabilized by feathers or fur.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("73f9274c-484f-4646-b771-d5b30859833c"),
				Name = "Dart",
				Hands = "1",
				Price = 1,
				Range = 20,
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Common.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0ba96534-b75d-4473-950b-7fe103dabb2e"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("9dc03fa9-2516-4892-bf25-3e2a9ff0598e"), Traits.Instances.Thrown.ID, "20 ft.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb876b13-2112-4172-8d99-8bc7c0854c8b"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
