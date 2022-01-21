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
    public class MeteorHammer : Template
    {
        public static readonly Guid ID = Guid.Parse("1c9e4d66-6360-4215-8686-1ab9d30655e3");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Meteor Hammer",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("c2fe014f-6998-4585-a6a7-b3e9a5700a23"),
				Name = "Meteor Hammer",
				Price = 300,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("a884e4ea-b8d7-4764-99eb-bfeff0b21460"), "This weapon consists of a long chain connected to a heavy weight at one end. When a wielder swings the weight by the chain, it builds momentum and can serve as a deadly bludgeon with incredible reach.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("69de6509-4989-451d-b532-41940069ec16"), Traits.Instances.Backswing.ID);
            builder.Add(Guid.Parse("73b68faa-129f-4a37-81dc-fd0844c6c52d"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("810b8bbc-3313-46cc-9089-2ccc874384fe"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("087235d2-1b95-4cfd-894c-f8c201405c07"), Traits.Instances.Trip.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01c2bf73-7183-4dce-a282-edc644ada0ce"),
                SourceId = LostOmensGodsAndMagic.ID,
                Page = 121
            };
        }
    }
}
