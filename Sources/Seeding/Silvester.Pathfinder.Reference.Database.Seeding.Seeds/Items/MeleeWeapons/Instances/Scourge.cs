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
    public class Scourge : Template
    {
        public static readonly Guid ID = Guid.Parse("299de1cf-c922-4a22-b924-38a9f345f8e7");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Scourge",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("e93ca95c-0047-40f4-8d9f-a924a58b4c75"),
				Name = "Scourge",
				Price = 10,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("7b0a2fbb-6aaf-4c74-b3d0-4c2d1c8f9c10"), "A scourge (also known as a cat-o'-nine-tails) is a set of several knotted cords made from cotton or leather and attached to a handle. While most scourges are more suitable for torture than combat, the weapons used by the Order of the Scourge have metal barbs woven in to pierce clothing and armor. The scourge is a martial melee weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("44f1f3ec-7668-4453-a900-9bd1c252302f"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("c702f40f-61a0-4c37-aa75-15e9f8abcacb"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("02d99bb1-c92c-4e27-9d12-19cbe63e40f3"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("340c7999-5758-48f7-831d-0ac825fb4f20"), Traits.Instances.Nonlethal.ID);
            builder.Add(Guid.Parse("4ada9ae8-d583-4ef3-9413-bc8c3c96d0af"), Traits.Instances.Sweep.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9525a2a2-bf28-40fe-a616-7d75151e2540"),
                SourceId = CharacterGuide.ID,
                Page = 80
            };
        }
    }
}
