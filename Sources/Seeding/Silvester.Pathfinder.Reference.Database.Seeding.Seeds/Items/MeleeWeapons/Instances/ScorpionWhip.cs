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
    public class ScorpionWhip : Template
    {
        public static readonly Guid ID = Guid.Parse("27e7a989-bd1f-4ed5-8cbe-4c1f5becda8d");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Scorpion Whip",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("1c13e6ef-e1cc-4cf9-8e73-98af5254cfcb"),
				Name = "Scorpion Whip",
				Price = 50,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("0dfdfd4c-65a8-4d06-b712-f47d4a4bf6a4"), "A scorpion whip has a series of razor-sharp blades set along its tip. Unlike ordinary whips, a scorpion whip doesn't have the nonlethal trait, making it deadlier in combat but less effective when the wielder seeks to bring in foes alive.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d0d2015c-2c2a-4758-85f7-61112869dc0f"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("54cf10c8-b29c-42d2-8d25-ff12b34489ad"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("160016ce-1b2a-4a09-a0ee-f82bb7d040d4"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("6df0c2ef-697a-4a62-9940-e2b37bc0492b"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("9ce6df99-730e-431e-b876-3d2f4d41f9c4"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4d83249-2b91-4078-93b5-5e3a3acfec2e"),
                SourceId = Pathfinder151.ID,
                Page = 77
            };
        }
    }
}
