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
    public class Mambele : Template
    {
        public static readonly Guid ID = Guid.Parse("b40db133-eb32-4046-a667-61c7abcddd57");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Mambele",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Axe.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("6efdcf78-34c0-4873-afdc-756f5223089e"),
				Name = "Mambele",
				Price = 60,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("cdaf2b55-24c8-4cfe-9d17-f6307786badd"), "Also known as a hunga munga or danisco, this hybrid knife-axe consists of a hilt and a blade that curves backward toward the wielder. The curve of the blade is such that after a victim has been struck by a mambele, more damage is dealt as the weapon is extracted from the victim's body.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("391b90f0-3e33-47f2-a80c-7e6eaa40587e"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("f85f621f-46f4-41c4-8a16-ce583b524ba2"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("909578d9-62e3-4721-a645-2ec5fc2e882f"), Traits.Instances.Thrown.ID);
            builder.Add(Guid.Parse("19cdc0c7-0cd2-44e4-8897-f47cac7043ea"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c46b5bd-52f6-49bf-937a-dbc402a35f80"),
                SourceId = LostOmensGodsAndMagic.ID,
                Page = 121
            };
        }
    }
}
