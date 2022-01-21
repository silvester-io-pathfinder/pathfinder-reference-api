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
    public class Flail : Template
    {
        public static readonly Guid ID = Guid.Parse("0887fa4f-7650-443d-af1b-2d8e23fe5a8c");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Flail",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("434ada52-4ae1-4091-9e4e-857bd6971a21"),
				Name = "Flail",
				Price = 100,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("56f8f0e0-7129-4599-ade6-3fa3ccf20048"), "This weapon consists of a wooden handle attached to a spiked ball or cylinder by a chain, rope, or strap of leather.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e48a08d8-4097-46cb-bc35-2bc8ca8ad76f"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("737e9fc4-e8dd-46f5-b5fc-2fd1005ddd3a"), Traits.Instances.Sweep.ID);
            builder.Add(Guid.Parse("459d82c9-0bc6-4cb2-83e7-b170b99b3c74"), Traits.Instances.Trip.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("139c816a-ef93-4a2d-9867-0fd641a4f3dd"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
