using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class TawLauncher : Template
    {
        public static readonly Guid ID = Guid.Parse("7f5df152-e9a8-4918-a561-2aae39f0938b");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Taw Launcher",
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = Bow.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7532a7e5-a7b5-4783-9332-f29b302f1a8e"), "Designed by conrasu warriors, this complex device resembles a crossbow and fires small wooden bullets known as taws. A system of blades within the launcher can rapidly reshape a taw as it's loaded, allowing the launcher to fire taws of different shapes, such as fléchettes.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("dcb12cce-e73f-4cc9-89f6-fff44662f4f5"),
				Name = "Taw Launcher",
				Hands = "2",
				Price = 1000,
				Reload = 1,
				Range = 100,
				Damage = "1d10",
				DamageTypeId = DamageTypes.Instances.Modular.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6b822ab0-dc75-4df2-929b-a3002ac5bdf9"), Traits.Instances.Deadly.ID, "d10");
            builder.Add(Guid.Parse("13f60930-a850-4b42-80e2-ce8655089ff6"), Traits.Instances.Modular.ID, "B, P or S");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c2cadd3-1f2e-442b-a75c-2cdfa563852e"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
