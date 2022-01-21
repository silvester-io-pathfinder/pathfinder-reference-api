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
    public class FilchersFork : Template
    {
        public static readonly Guid ID = Guid.Parse("285c5d1b-a837-4065-9005-28420b0b8e00");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Filcher's Fork",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Spear.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("2aea9ce3-08ce-423c-aa64-b819f03c9bba"),
				Name = "Filcher's Fork",
				Price = 100,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("97154ef0-9a7d-4cc8-b3be-8eeec3a9cfb2"), "This halfling weapon looks like a long, two-pronged fork and is used as both a weapon and a cooking implement.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3d45771f-746f-4d0e-9b12-eee5462b7c8a"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("1282b203-a6bd-4fae-868e-22fc9734b564"), Traits.Instances.Backstabber.ID);
            builder.Add(Guid.Parse("cbdcd886-06d8-4727-b4e7-a574ce970ae0"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("93f3d964-f9d2-4ff0-b323-1652accc4bc4"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("59bde4f4-7260-41ce-ae38-f808b9fbdf7a"), Traits.Instances.Thrown.ID);
            builder.Add(Guid.Parse("1d00918c-f68e-4c77-a482-08de67ea6b96"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd7c2cd0-bfe4-4175-9926-f65cb443f34e"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
