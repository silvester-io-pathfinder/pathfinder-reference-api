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
    public class ButcheringAxe : Template
    {
        public static readonly Guid ID = Guid.Parse("b74845be-5e15-4b11-b2c8-ed2dba28f3d7");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Butchering Axe",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Axe.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("5fc424c9-a53a-46d9-bdad-7d4804f80494"),
				Name = "Butchering Axe",
				Price = 800,
				Hands = "2",
				Damage = "1d12",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("4bbc3abe-d7f6-4872-8b23-69a9dcfc1912"), "Invented by Belkzen's zealous Steel-Eaters, the butchering axe has an oversized head and a long, thick haft counterbalanced with steel or stone. The weapon's sweeping strokes inflict immense damage, particularly against groups of foes, and can push dangerous opponents away to a safe distance. All of these qualities are particularly useful against the lumbering zombie hordes of the Whispering Tyrant. Correspondingly, butchering axes are often wielded by orc and half-orc Crimson Reclaimers of Lastwall.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("829deaa8-c78a-4d0a-83ef-e6a587d92ae9"), Traits.Instances.Orc.ID);
            builder.Add(Guid.Parse("5617895b-8ccf-42c7-a46f-20e46f932bf5"), Traits.Instances.Shove.ID);
            builder.Add(Guid.Parse("23752f26-51df-4943-9a87-8d7664fde460"), Traits.Instances.Sweep.ID);
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12e80d36-530a-4988-933e-6ba43fc6c6fa"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 105
            };
        }
    }
}
