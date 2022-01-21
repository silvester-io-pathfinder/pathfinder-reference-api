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
    public class FlintlockPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("1ee252ed-864b-4351-991a-0a6e2af48fa2");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Flintlock Pistol",
                WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4ccd89a7-01e1-4489-bbd5-e764940b889c"), "Though less accurate and powerful than a flintlock musket, the flintlock pistol is a preferred weapon of privateers thanks to its more compact size and affordability. Pirate captains often wear a brace of such pistols in a bandolier so they can draw and fire without stopping to reload.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("9e2fa031-4d02-4b8f-8910-b12c78e6749f"),
				Name = "Flintlock Pistol",
				Hands = "1",
				Price = 600,
				Reload = 1,
				Range = 40,
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("90e9b92c-1498-4999-b3ca-082217addb2e"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("5453587d-e04d-4e02-b1cf-288110257a16"), Traits.Instances.Fatal.ID, "d10");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ccc25d3a-46c4-42d1-ad24-a7c4f876bcde"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
