using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class Shuriken : Template
    {
        public static readonly Guid ID = Guid.Parse("1139c9c1-84b6-4e03-85bd-a7d779716297");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Shuriken",
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Dart.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("90ca8ae6-d7c5-4193-821f-981db03c6d52"), "This “throwing star” is a small piece of flat metal with sharp edges, designed to be flung with a flick of the wrist.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("63be5a02-5221-4681-9343-be86af9df6a3"),
				Name = "Shuriken",
				Hands = "1",
				Price = 1,
				Reload = 0,
				Range = 20,
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4ffec618-7074-46b0-b9a6-e09c522e9a8a"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("e06a942e-6a1b-496b-ae16-7b5a4f0735fa"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("94543fd6-5542-4e4a-b366-74ceb6d30c1b"), Traits.Instances.Thrown.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ee225e2-9330-431e-809b-6239b917be67"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
