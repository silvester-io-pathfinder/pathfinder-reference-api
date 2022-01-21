using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class AspCoil : Template
    {
        public static readonly Guid ID = Guid.Parse("395d5c86-f2d6-49c6-b9d1-6f4db798810b");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Asp Coil",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("94054756-51ef-4177-ac73-49e0d7c9964e"),
				Name = "Asp Coil",
				Price = 1000,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("6d25955d-4c99-418f-988e-dbbfb658b299"), "The asp coil, named both for its slithering striking style and its usage among Aspis Consortium agents, has two forms. In sword form, it resembles an elegant, oddly balanced sword. However, with a twist of the pommel, the blade splits into a series of segments connected by elaborate metal cables.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3d419258-cb07-4503-92b1-abd38ec5f331"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("d23ed829-2581-4eae-9772-703699c06c80"), Traits.Instances.Versatile.ID, "P");
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e93b527f-8e64-482c-ab49-c0cf7ce2508d"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 105
            };
        }
    }
}
