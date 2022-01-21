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
    public class OrcNecksplitter : Template
    {
        public static readonly Guid ID = Guid.Parse("bb3d9d98-06cc-4e04-aedc-bcff42e9389b");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Orc Necksplitter",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Axe.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("c141ec6d-77fd-4e1c-9739-b58c12509053"),
				Name = "Orc Necksplitter",
				Price = 200,
				Hands = "1",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("6240f8af-2d8f-4346-8e92-e61f4ebfce05"), "This single-bladed bearded axe has a jagged blade that's perfect for separating bone from tendon and cartilage.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3f9394bf-5e1e-4bce-baab-a7fa31fe07e3"), Traits.Instances.Forceful.ID);
            builder.Add(Guid.Parse("990ef115-6f73-466d-97e9-951beaa1912c"), Traits.Instances.Orc.ID);
            builder.Add(Guid.Parse("2880558d-7adb-4792-b683-cb7d8998ca35"), Traits.Instances.Sweep.ID);
            builder.Add(Guid.Parse("4ef0cf49-ff29-4517-98d1-5add9ffc291f"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("217fa626-b44b-4373-a436-41b4c4730380"),
                SourceId = CoreRulebook.ID,
                Page =  281
            };
        }
    }
}
