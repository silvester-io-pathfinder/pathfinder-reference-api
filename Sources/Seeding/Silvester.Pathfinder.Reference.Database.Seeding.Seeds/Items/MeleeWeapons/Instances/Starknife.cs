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
    public class Starknife : Template
    {
        public static readonly Guid ID = Guid.Parse("46e21ee5-d51f-496f-861e-c50dbe21ccca");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Starknife",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("540b8743-7778-4e87-bb74-a927cccc4f3d"),
				Name = "Starknife",
				Price = 200,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("8a83ee28-969f-49eb-87e5-8025d7f7ead0"), "From a central metal ring, four tapering metal blades extend like points on a compass rose. When gripping a starknife from the center, the wielder can use it as a melee weapon. It can also be thrown short distances.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7819233b-08ee-4a01-9b8f-7743f1ca07b9"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("ff64aa6f-b6b3-4f01-ab6b-dadee2471e11"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("66af2469-d35b-4496-b203-3593d29ba7b8"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("9de64fe3-8059-454c-af2a-104af0bca7e1"), Traits.Instances.Thrown.ID);
            builder.Add(Guid.Parse("d3f47e08-8a0e-40ef-9f2e-538b5eaf8833"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4485f05-26c5-4afa-9bd0-971c45bf9218"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
