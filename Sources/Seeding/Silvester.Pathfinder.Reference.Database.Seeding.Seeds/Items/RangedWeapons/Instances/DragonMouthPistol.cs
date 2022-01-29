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
    public class DragonMouthPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("0c14860d-808e-43ab-a623-4e24d755b4d9");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Dragon Mouth Pistol",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ab071caf-5718-4b11-9367-dcb9f7597d7a"), "Similar to the blunderbuss, a dragon-mouth pistol fires pellets from a flared barrel. Though less powerful than a blunderbuss, the dragon-mouth pistol is appreciated for its portability and one-handed design. Though the name was coined because of the destructive belch of this handheld scatter weapon, many gunsmiths craft dragon-mouth pistols with elaborate embellishments that resemble a stylized dragon's maw framing the barrel.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("48f356e6-3f9d-4fd5-b3e0-0014faa3d63a"),
				Name = "Dragon Mouth Pistol",
				Hands = "1",
				Price = 900,
				Reload = 1,
				Range = 20,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("61ce4994-f1f4-48e1-bff6-af84d4ea9a7b"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("d045688a-4ac1-47a4-a1a7-6a3bf6d36a56"), Traits.Instances.Scatter.ID, "5 ft.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d418054-83f7-4ce2-bbcb-f21aaea6b78a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
