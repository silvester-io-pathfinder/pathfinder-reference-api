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
    public class Lance : Template
    {
        public static readonly Guid ID = Guid.Parse("27dd4f47-af0a-460f-9b4f-6d841b1d702e");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Lance",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Spear.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("8fe0a407-9a7c-4244-9f7e-177cb19c280d"),
				Name = "Lance",
				Price = 100,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("093facac-5cd4-4463-b26d-97f9174c8d11"), "This spear-like weapon is used by a mounted creature to deal a great deal of damage.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("89a15f67-315b-4aee-b8be-78da9622c6fb"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("51319b14-cfbd-46b6-b19b-3b74a775f7ae"), Traits.Instances.Jousting.ID);
            builder.Add(Guid.Parse("a39b7829-1f03-4b9d-9496-8244d7219320"), Traits.Instances.Reach.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae37faf4-c071-4dd9-bdda-262e1495fc78"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
