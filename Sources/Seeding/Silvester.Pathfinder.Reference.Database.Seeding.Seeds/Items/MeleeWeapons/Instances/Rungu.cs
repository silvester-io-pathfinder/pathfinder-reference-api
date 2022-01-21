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
    public class Rungu : Template
    {
        public static readonly Guid ID = Guid.Parse("361b69e6-127f-4c0b-8a0a-b15f63778a76");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Rungu",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("0a1f8f45-5ea9-4c9c-b0ba-9ca442655d91"),
				Name = "Rungu",
				Price = 40,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("57e72469-075e-4b01-b46b-b3aef3f080a1"), "This specialized club is designed for throwing and is useful for both combat and hunting. Though gripplis didn't create the rungu originally, many grippli communities have adopted it as the weapon of choice for hunting creatures that hide high in treetops.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2c2eb6da-7945-4405-8cfe-55d86f4a6238"), Traits.Instances.Grippli.ID);
            builder.Add(Guid.Parse("c7d38276-12ac-40a2-8234-aeb8337b5aac"), Traits.Instances.Shove.ID);
            builder.Add(Guid.Parse("c66483bd-78d7-40c7-b4a8-b5abbefc0347"), Traits.Instances.Thrown.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bb96701-ea4f-4e80-a828-fb86b3c81e4b"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
