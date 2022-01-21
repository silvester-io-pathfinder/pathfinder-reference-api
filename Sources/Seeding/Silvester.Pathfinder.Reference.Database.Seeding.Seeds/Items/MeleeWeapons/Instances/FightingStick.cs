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
    public class FightingStick : Template
    {
        public static readonly Guid ID = Guid.Parse("3dda78c7-e32c-4d34-8aba-eb45412798d0");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Fighting Stick",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("c1ea6d8e-eeed-4ce1-b3c9-fb19babf6bf4"),
				Name = "Fighting Stick",
				Price = 50,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("5eb529a9-c394-46c4-bb58-188093416bd2"), "This hard but flexible longsword-length piece of wood looks more like a pole than a weapon, but can be deadly in the right hands. While generally not used for combat outside of Song�o culture, some halflings have become so proficient as to make it just as effective as a blade in a fight. Many halflings will even sing to maintain a certain tempo and rhythm during combat. It deals 1d6 bludgeoning damage. A fighting stick is a martial one-handed melee weapon in the club weapon group")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4bb40078-458f-483c-b3a3-a24ab60006bf"), Traits.Instances.Backswing.ID);
            builder.Add(Guid.Parse("b44dffec-c385-433e-9375-f4d37b42eec8"), Traits.Instances.Halfling.ID);
            builder.Add(Guid.Parse("c26c7a4b-9d0b-4cd5-a1b3-3e28a0ed03f8"), Traits.Instances.Nonlethal.ID);
            builder.Add(Guid.Parse("331d60df-445c-43c8-917f-ddc114999037"), Traits.Instances.Shove.ID);
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17da1ed3-8367-4dd1-b621-09d20ed02b1c"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 86
            };
        }
    }
}
