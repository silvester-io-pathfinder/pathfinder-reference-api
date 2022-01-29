using Silvester.Pathfinder.Reference.Database.Models.Entities;
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
    public class Jezail : Template
    {
        public static readonly Guid ID = Guid.Parse("3a578ba6-e617-4c84-b7cb-67c34b1a1268");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Jezail",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d52f18d5-37df-4f8a-a62e-e0436600b1ae"), "Jezails are simple, efficient long guns developed in Casmaron that typically feature a custom stock and a flintlock firing mechanism. Though lacking the range and stopping power of an arquebus or the raw force of a harmona gun, the jezail is an elegant, well-balanced weapon suitable for a variety of combat situations. It's even possible to tuck it under one arm to fire a less accurate attack that uses only one hand.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("8112ff98-cd76-4c23-b7e9-4fa7e415ca83"),
				Name = "Jezail",
				Hands = "1",
				Price = 1100,
				Reload = 1,
				Range = 90,
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d986138b-2b82-49d6-a17e-c757de47feca"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("192e955d-056d-4c66-ae8b-aab231fb85ef"), Traits.Instances.FatalAim.ID, "d12");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("251d1c56-ac84-469b-b125-1f24602ec431"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
