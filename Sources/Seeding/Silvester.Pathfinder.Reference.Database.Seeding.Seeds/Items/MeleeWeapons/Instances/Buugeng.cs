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
    public class Buugeng : Template
    {
        public static readonly Guid ID = Guid.Parse("09595caf-7209-4ffa-b4cc-524a9c9807c0");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Buugeng",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("3a4f9abb-4f10-4974-8ef6-2e525bf6092f"),
				Name = "Buugeng",
				Price = 400,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("3e9d520b-b962-4de1-8e05-0e1dff38775a"), "A blade of conrasu design, a buugeng has a unique, curved shape that allows it to rotate smoothly in the hand of a trained warrior. This spinning motion makes it easier to attack multiple foes at once with the weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("016e884b-9f36-488c-88a2-6cc30a5a1dad"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("65f44fa5-26f3-40eb-9052-1a04b6a5a825"), Traits.Instances.Conrasu.ID);
            builder.Add(Guid.Parse("1b6bc316-412a-4a01-ac0b-af6d8dda0cba"), Traits.Instances.Sweep.ID);
            builder.Add(Guid.Parse("fcf8b661-3676-4e95-90ec-0fe411ec91d4"), Traits.Instances.Twin.ID);
            builder.Add(Guid.Parse("400bd2a9-3d30-47a7-9c50-8d2972aa9227"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0df0f9b4-f422-4334-949b-0c62d75e5454"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
