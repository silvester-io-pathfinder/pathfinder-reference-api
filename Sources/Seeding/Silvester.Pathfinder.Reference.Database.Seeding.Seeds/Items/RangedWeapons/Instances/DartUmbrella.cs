using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class DartUmbrella : Template
    {
        public static readonly Guid ID = Guid.Parse("6371181a-3318-4a53-9393-c4d6bcdd5c2f");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Dart Umbrella",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Dart.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("412e1cdd-d1ff-4115-9e13-b38c6387572c"), "This umbrella fires tiny blowgun darts from its ferrule with a twist of the handle. The darts are loaded into the shaft, and though the damage they deal is minimal, the dart umbrella is an inconspicuous weapon easy to slip past inspections.");
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("35895029-64fc-40d5-8fb3-0d914afba11d"),
				Name = "Backpack Ballista",
				Hands = "1",
				Price = 100,
				Reload = 1,
				Range = 30,
				Damage = "1",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f243b6eb-1408-4d96-991f-af0a71de2d69"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("e17fb309-f4ea-4e6a-860a-7f9885ce137f"), Traits.Instances.Concealable.ID);
            builder.Add(Guid.Parse("a314b2d4-e76e-4367-8457-32f480798404"), Traits.Instances.Nonlethal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13b39a8a-514c-42ff-8957-075c7788b32b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 63
            };
        }
    }
}
