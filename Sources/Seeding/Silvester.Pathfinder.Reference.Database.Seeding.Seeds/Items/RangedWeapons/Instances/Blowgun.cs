using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
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
    public class Blowgun : Template
    {
        public static readonly Guid ID = Guid.Parse("f7462ef0-62d3-48ad-bc24-e80318b98455");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Blowgun",
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Dart.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9aaa0f0a-ee30-4cb9-a8dc-c09312cff065"), "This long, narrow tube is used for shooting blowgun darts, using only the power of a forcefully exhaled breath.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("1ec25091-e2c6-49bc-8256-3000f9e7a62e"),
				Name = "Blowgun",
				Hands = "1",
				Price = 10,
				Reload = 1,
				Range = 20,
				Damage = "1",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Common.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c6370e0a-c01f-4c5e-a490-40ff57507c39"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("f98963d7-cfe1-4c31-87b6-791cc408518e"), Traits.Instances.Nonlethal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00860b13-76fc-42d7-a5d7-00a6591e21dc"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
