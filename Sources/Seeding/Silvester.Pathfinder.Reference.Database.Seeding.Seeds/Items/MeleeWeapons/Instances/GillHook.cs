using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class GillHook : Template
    {
        public static readonly Guid ID = Guid.Parse("8f28ae9d-f0a6-4ed9-af09-e44de58acd82");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Gill Hook",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Spear.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("021a8603-9de6-47d4-8cd6-71e94fa1c499"),
				Name = "Gill Hook",
				Price = 200,
				Hands = "2",
				Damage = "1d10",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("bd70fcca-b692-4133-9af3-ae64fe0e61b2"), "This spear has a specialized hook just before the tip that can catch on the gills of large fish. Azarketis primarily use this to hunt sharks, but it can also be used to hook flesh or armor. This weapon is common on the Isle of Kortos and within azarketi settlements.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c92b928a-17c4-44b1-9e05-ef2962d88303"), Traits.Instances.Azarketi.ID);
            builder.Add(Guid.Parse("e962e501-7f43-42f3-9e3b-c4aaf6173ff7"), Traits.Instances.Grapple.ID);
            builder.Add(Guid.Parse("52354e54-af7b-4f22-8ae0-664198d82bcb"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("8f92ae14-4089-496b-9a36-0ebd735725dc"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd53aa21-92e7-4268-ad3a-76d4d3f48290"),
                SourceId = AzarketiAncestryWebSupplement.ID,
                Page = 1
            };
        }
    }
}
