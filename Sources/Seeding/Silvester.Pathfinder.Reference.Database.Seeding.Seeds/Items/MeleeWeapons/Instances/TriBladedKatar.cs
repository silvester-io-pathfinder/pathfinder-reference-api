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
    public class TriBladedKatar : Template
    {
        public static readonly Guid ID = Guid.Parse("4242eba9-a9b8-4fdb-b6e0-59dc6bb81de6");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Tri-Bladed Katar",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("60cbf786-afdc-4b0b-9442-07437d37122f"),
				Name = "Tri-Bladed Katar",
				Price = 80,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("65ddccd8-a58c-4b50-a2d4-4c7000637712"), "This punching dagger resembles the standard katar, save that a pair of blades can be folded out from the center blade, transforming the weapon into a starburst shape well suited to catching foes' weapons.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6b4c6876-15e0-4610-85ac-63ce18123999"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("c44c5b77-f06a-42e4-aaf1-fa41d0890b22"), Traits.Instances.Fatal.ID, "d8");
            builder.Add(Guid.Parse("ace28308-b8ee-4f25-83bb-fe90ff50b362"), Traits.Instances.Monk.ID);
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df296208-bf6d-4b41-84a9-efa9ed2bc24e"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 106
            };
        }
    }
}
