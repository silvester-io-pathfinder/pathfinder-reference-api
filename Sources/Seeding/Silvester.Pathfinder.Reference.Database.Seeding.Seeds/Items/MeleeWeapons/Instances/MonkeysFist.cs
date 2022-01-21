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
    public class MonkeysFist : Template
    {
        public static readonly Guid ID = Guid.Parse("14f657da-fab9-4369-9fac-ded23f1d2b6f");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Monkey's Fist",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("293811e3-ae9c-41b3-97ed-7de4d401e714"),
				Name = "Monkey's Fist",
				Price = 10,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("e25e669f-5d30-47f9-86aa-957ab0e96f6a"), "Also called a 'slungshot', the monkey's fist is a short length of rope ending in a thick knot wrapped around a metal weight. You can tie the loose end of a monkey's fist to your wrist; if you are Disarmed, the weapon remains secured to your wrist rather than falling to the ground, though you must use an Interact action to grip it before using it again. A monkey's fist is a martial melee weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("edd37bc4-86a6-453d-b601-e9e1227ba4db"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("a923871d-2241-4d41-97c7-1e2534dd4995"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("00afd1a2-990a-47a1-94d5-55dd91080f77"), Traits.Instances.Nonlethal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("341b16f6-b1ad-4bd7-b3a0-5b9cccff4e1e"),
                SourceId = Pathfinder157.ID,
                Page = 78
            };
        }
    }
}
