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
    public class DoubleBarreledPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("c0eb531d-c69b-4180-b5b6-7134d5017861");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Double-Barreled Pistol",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("2208cff8-834b-4592-95ba-758fcc4af630"), "This flintlock pistol has two side-by-side barrels. Though less accurate than a standard pistol, a double-barreled pistol is a useful and versatile weapon. It�s generally banned in areas where duels with pistols are relatively common, in much the same way that arriving at an aristocratic duel with a scattergun would be considered crass, at best.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("190fb8fd-0e51-4252-998d-c789c866ee6d"),
				Name = "Double-Barreled Pistol",
				Hands = "1",
				Price = 700,
				Reload = 1,
				Range = 30,
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9dd97672-93b3-4e06-b220-d796faf8f4f4"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("d1a084e3-3b24-48bf-8bd0-48c0db3acdc3"), Traits.Instances.DoubleBarrel.ID);
            builder.Add(Guid.Parse("9240c389-8517-4906-a791-e0d76c0dc62c"), Traits.Instances.Fatal.ID, "d8");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c3ac77c-f234-47d7-bbfc-b4b2b32c6740"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
