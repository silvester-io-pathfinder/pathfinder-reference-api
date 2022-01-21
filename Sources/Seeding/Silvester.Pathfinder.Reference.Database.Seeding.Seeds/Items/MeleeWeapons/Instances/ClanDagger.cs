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
    public class ClanDagger : Template
    {
        public static readonly Guid ID = Guid.Parse("2ef4b9ed-c528-44ec-9123-6b92234662c1");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Clan Dagger",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("bbd1f6ad-919f-49ae-963c-6227361caa3d"),
				Name = "Clan Dagger",
				Price = 200,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("c19dd134-1912-4ca5-88af-870cb173566a"), "This broad dagger is carried by dwarves as a weapon, tool, and designation of clan. Losing or having to surrender a clan dagger is considered a mark of embarrassment to most dwarves.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f7ff7e6f-e506-4c31-b66d-e6498dc59a9e"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("2e4cae91-df5d-4a0c-a39d-cb75dd415f1c"), Traits.Instances.Dwarf.ID);
            builder.Add(Guid.Parse("c5920b31-3028-4776-9922-4a9ab0a41f9e"), Traits.Instances.Parry.ID);
            builder.Add(Guid.Parse("4c144d89-2358-4221-9d98-dd5227209cfa"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f9c25417-f3c0-4f35-a20b-8c11b604bcef"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a12349b-087d-4400-b37f-65d5297d16a2"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
