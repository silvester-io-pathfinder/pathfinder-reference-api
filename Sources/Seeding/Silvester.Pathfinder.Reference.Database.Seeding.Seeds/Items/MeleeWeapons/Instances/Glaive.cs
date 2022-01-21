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
    public class Glaive : Template
    {
        public static readonly Guid ID = Guid.Parse("af49cf0b-69d2-4fa4-820f-7b6806c213f3");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Glaive",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Polearm.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("f5d13690-5915-4408-b167-1e2d09651188"),
				Name = "Glaive",
				Price = 100,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("a325fbcc-e810-45a3-a9e4-9568dc314110"), "This polearm consists of a long, single-edged blade on the end of a 7-foot pole. It is extremely effective at delivering lethal cuts at a distance.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("05f276ff-4529-43df-a247-bcd9906644da"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("d9068e37-865f-4b7b-a1a4-3b8fb2d4bd2d"), Traits.Instances.Force.ID);
            builder.Add(Guid.Parse("cb12ba79-1349-4fbf-bf93-48423599f303"), Traits.Instances.Reach.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec2e8eb3-97fc-4c12-a81d-fbfc9ad51ad5"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
