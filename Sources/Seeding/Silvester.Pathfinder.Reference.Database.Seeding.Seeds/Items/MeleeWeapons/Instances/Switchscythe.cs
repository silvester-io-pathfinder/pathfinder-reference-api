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
    public class Switchscythe : Template
    {
        public static readonly Guid ID = Guid.Parse("3b66263d-dd86-4aee-82bd-f08dda7405c5");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Switchscythe",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Pick.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("3a8ed2f9-eaa2-406a-b557-fa94de17df80"),
				Name = "Switchscythe",
				Price = 1200,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("6ea88150-cf33-4da6-af5d-1a888ab9c226"), "Another complex gnome invention, the switchscythe is designed for versatility. The curved blade is partly hollow, containing a long rod of wood or metal; the rod can be pulled perpendicular to the blade, turning the switchscythe from a sweeping, axe-like blade into a hooked pick capable of grappling a foe.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e603ba2a-37d3-4274-964a-d556da787832"), Traits.Instances.Fatal.ID, "d10");
            builder.Add(Guid.Parse("c195bd8c-c397-4ac9-8108-f7699f629f87"), Traits.Instances.Gnome.ID);
            builder.Add(Guid.Parse("370c952d-a9ac-4b77-a98a-49c3b8ef87c1"), Traits.Instances.Modular.ID, "P and Grapple, or S and Sweep");
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("014fa188-1aa4-4f11-bcb1-7c53312ca962"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 106
            };
        }
    }
}
