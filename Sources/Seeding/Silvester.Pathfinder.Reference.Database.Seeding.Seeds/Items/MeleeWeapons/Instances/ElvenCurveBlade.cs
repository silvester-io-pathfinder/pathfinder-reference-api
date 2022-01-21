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
    public class ElvenCurveBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("07b728c8-b6a9-4d6c-97ec-acda2ef83daa");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Elven Curve Blade",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("9a455370-e382-4ccd-95f1-311d76348f03"),
				Name = "Elven Curve Blade",
				Price = 400,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("04b93f30-eb15-46d1-b74e-7bc458ab2bb7"), "Essentially a longer version of the scimitar, this traditional elven weapon has a thinner blade than its cousin.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("276a384b-6f82-4636-9eca-1c422ff6d9aa"), Traits.Instances.Elf.ID);
            builder.Add(Guid.Parse("7d846161-6ea2-49d9-aee6-4b3cd6a41ee3"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("0e9d4195-8ed8-4b12-a2a7-dbb1c9ba3125"), Traits.Instances.Forceful.ID);
            builder.Add(Guid.Parse("3e9b0dd9-c1d1-44ff-a3cf-a2c5d6a083d8"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d40f8d4-0dfc-4bb0-9998-288dd43fcfea"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
