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
    public class Karambit : Template
    {
        public static readonly Guid ID = Guid.Parse("4229c2b7-ba0a-48a1-be7a-4b8f52c190f8");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Karambit",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("a5b4838d-c825-4c13-b8ee-7b58c90e9acf"),
				Name = "Karambit",
				Price = 200,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("58445cfc-858e-4f69-a032-6dd9f604b08e"), "This small curved blade resembles a tiger's claw and is capable of delivering deep wounds.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a4cf4c11-c4da-4d01-98f9-937564ae76f0"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("53479a82-2379-4417-b9f8-b21cc5a70522"), Traits.Instances.Fatal.ID, "d8");
            builder.Add(Guid.Parse("9a5ed881-7953-4246-812d-d976a96136b3"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("233d29b0-5048-4f0e-8510-57258401698e"), Traits.Instances.Versatile.ID, "S");
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0390ef5-23f0-452d-99f1-88f551c17f96"),
                SourceId = Sources.Instances.Pathfinder166.ID,
                Page = 76
            };
        }
    }
}
