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
    public class Katana : Template
    {
        public static readonly Guid ID = Guid.Parse("b3b26911-43d7-4771-b374-19e3aac3033b");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Katana",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("a8ec4373-593d-4b2c-a871-1240b41fcfe5"),
				Name = "Katana",
				Price = 200,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("de1c73c9-a7ee-4877-8727-cb5201a61628"), "A katana is a curved, single-edged sword known for its wickedly sharped blade.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("97372f63-60e4-4c56-a153-bfd532359a9d"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("43393984-a151-42a8-a52d-ce05cb1236b9"), Traits.Instances.TwoHand.ID);
            builder.Add(Guid.Parse("f661f7c9-a86c-418d-90c6-ceaf5ab9bdd5"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("452c8bcb-501a-4038-80c1-3afd3a04c762"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9079c6d1-f93b-4916-a0f0-20e0b8a0328d"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
