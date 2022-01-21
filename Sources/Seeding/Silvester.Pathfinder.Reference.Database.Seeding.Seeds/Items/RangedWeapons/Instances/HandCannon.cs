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
    public class HandCannon : Template
    {
        public static readonly Guid ID = Guid.Parse("81f66605-b4f0-41c9-b304-aa21d6cbaef6");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Hand Cannon",
                WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4bef6204-b1d8-4565-af7e-ed6ad23a218d"), "Popular among privateers and mercenaries in Goka, hand cannons are little more than a hardened tube with a handle and external ignition attached. A hand cannon can be used to fire almost anything that can be packed into its barrel. The wielder of a hand cannon can change the damage type granted by its modular trait as part of the same Interact action used to reload.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("2357c7b4-02e1-40f5-b125-5836114132f8"),
				Name = "Hand Cannon",
				Hands = "1",
				Price = 500,
				Reload = 1,
				Range = 30,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("36b63bd0-5b18-441e-9faf-f4c18e5cf3ca"), Traits.Instances.Modular.ID, "B, P or S");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("809173dd-7282-419e-bf2d-9674f1fb5e7f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
