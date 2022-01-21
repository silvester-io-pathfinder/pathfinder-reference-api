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
    public class Tonfa : Template
    {
        public static readonly Guid ID = Guid.Parse("4d73af95-8283-4226-8f96-b6f724e215ca");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Tonfa",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Brawling.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("bbc72cb8-be4d-4804-b774-5d790d33b672"),
				Name = "Tonfa",
				Price = 10,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("67852a8a-687d-41cc-a953-ed3f87a9b549"), "These L-shaped fighting batons are good for striking and blocking. The wielder holds the handle and either spins the stick or strikes with the stick covering the forearm.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("cb3126ea-a099-4e6c-bf6f-a866732a926a"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("d4d2b3f6-147a-4892-8ade-373979e32801"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("bae723d0-53ed-4903-a1f2-d8c5d122bc7a"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("60bb261c-9545-4e3c-beb7-dd81c7fbcae1"), Traits.Instances.Parry.ID);
            builder.Add(Guid.Parse("5442e651-d7e1-4842-b052-bc62418cee93"), Traits.Instances.Twin.ID);
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec836941-46c9-416d-94cb-ac0581598ae6"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 106
            };
        }
    }
}
