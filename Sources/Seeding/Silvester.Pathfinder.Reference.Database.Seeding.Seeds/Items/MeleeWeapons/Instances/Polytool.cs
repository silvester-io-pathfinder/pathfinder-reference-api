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
    public class Polytool : Template
    {
        public static readonly Guid ID = Guid.Parse("24f3accf-0ba9-491d-94fc-4e8abe71ff23");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Polytool",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("de28268e-3098-41df-a470-652fafd8ff75"),
				Name = "Polytool",
				Price = 1000,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Modular.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("c1568950-8824-4791-bd78-1e85317977a1"), "The polytool is a small metal rod with a number of simple tools folded inside. The user can extend a long ceramic blade, as well as an awl, a chisel, a file, flint and steel, a hook, an inkpen, a magnifying glass, pliers, scissors, and a small saw. The flint and steel can be used up to 10 times before needing to be replaced. Though inspired by advanced Numerian technology, the polytool is a simple enough feat of metalworking that any blacksmith could produce it— perfect for the goddess Casandalee to spread innovation farther than actual Numerian tech could reach.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7a76b2dd-512b-4a04-b9ab-83bd4996d8fc"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("b11252dc-c3ec-427d-b52b-04e1fe79accb"), Traits.Instances.Modular.ID);
            builder.Add(Guid.Parse("b8b9f767-6807-4eb4-8735-b61e509487b3"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f68749e-73f2-4fd7-81ad-440d303de9e5"),
                SourceId = LostOmensGodsAndMagic.ID,
                Page = 121
            };
        }
    }
}
