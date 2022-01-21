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
    public class CombatGrapnel : Template
    {
        public static readonly Guid ID = Guid.Parse("6a5291fb-45dc-426b-8605-d808c123759c");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Combat Grapnel",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("c4fe77ed-bfcf-4708-b696-56528b8b5f97"),
				Name = "Combat Grapnel",
				Price = 90,
				Hands = "2",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("95ec1092-321f-4356-91bb-8ba396e2caf2"), "Although grappling hooks typically serve as a climbing tool, this specially reinforced grapnel attached to a rope up to 10 feet long can be swung as a weapon. This is a martial melee weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f8171fe9-c051-4ba9-a454-69a40401a4cb"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("c15cb1bc-2fd1-44d5-a1ed-b8fd882ef909"), Traits.Instances.Grapple.ID);
            builder.Add(Guid.Parse("3c6ce120-d2a6-46ed-abf9-0c0c83c25090"), Traits.Instances.Tethered.ID);
            builder.Add(Guid.Parse("47e0e1fe-915e-4057-8284-df88f391f1b3"), Traits.Instances.Thrown.ID);
            builder.Add(Guid.Parse("acf99db8-b41e-414e-99db-9d61e70a8e17"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53c212b5-cb72-4f75-a597-98bdd4181af0"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 80
            };
        }
    }
}
