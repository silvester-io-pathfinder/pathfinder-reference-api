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
    public class BoardingPike : Template
    {
        public static readonly Guid ID = Guid.Parse("c0c4e1e1-fc1c-4a9e-8797-8f2eabaeec50");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Boarding Pike",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Polearm.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("af98475c-fee4-4167-9502-5c1ef1b30118"),
				Name = "Boarding Pike",
				Price = 80,
				Hands = "2",
				Damage = "1d10",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("b809248e-3dd3-43cf-b5f5-670ce3d288b3"), "Taking the form of a longspear fitted with crossbars or hooks, a boarding pike provides its wielder a sharp implement that's as adept at shoving enemies off a ship's railings as facilitating the boarding of other vessels. This is a martial melee weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3fa7f05d-6241-4f88-bad9-712712b5eb32"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("f272fc3b-9774-44f4-affe-b2d76ce1a5ee"), Traits.Instances.Shove.ID);
            builder.Add(Guid.Parse("6a9f578d-b3c7-4bdf-a2de-bccd8ead3657"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa76307d-e009-4ee4-96a5-17aa0bbfa921"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 80
            };
        }
    }
}
