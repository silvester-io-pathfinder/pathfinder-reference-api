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
    public class BladedDiabolo : Template
    {
        public static readonly Guid ID = Guid.Parse("3bf26277-c214-4a31-aa61-6ae3c3f75ea3");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Bladed Diabolo",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("ac0c0941-dff9-4aa2-9278-c9ec0eb9ab26"),
				Name = "Bladed Diabolo",
				Price = 200,
				Hands = "2",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("76d94089-6eb9-4c46-a2b1-b3fbb0777f2c"), "This weapon consists of two bladed discs joined by a central axel, and is spun on a rope whose ends are attached to wand-like sticks. The wielder can hurl the diabolo from the rope like a stone from a sling, or swing it on the rope in melee.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("34bc2323-0d48-4117-831c-26ce8fc2eced"), Traits.Instances.Backswing.ID);
            builder.Add(Guid.Parse("a93e8bdb-d31f-49b4-b196-39acacce41c3"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("6e597f04-ad5d-4ebb-bd24-ee5c429a69d6"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("78575b48-5df8-440c-9e61-378a58228b0c"), Traits.Instances.Thrown.ID);
            builder.Add(Guid.Parse("f6886d79-8a9c-452e-aec4-47a228746c2a"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("cbd5c728-160e-4104-b176-8039e293b434"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f07df8e3-e1fa-4ca6-ae6b-6864594d348a"),
                SourceId = Pathfinder151.ID,
                Page = 77
            };
        }
    }
}
