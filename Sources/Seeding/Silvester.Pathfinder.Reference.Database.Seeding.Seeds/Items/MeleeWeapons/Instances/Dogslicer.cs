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
    public class Dogslicer : Template
    {
        public static readonly Guid ID = Guid.Parse("9bbc2b31-fae2-4ea1-8c7e-45896c24f111");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Dogslicer",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("606af594-584f-40f1-bb4a-2fd730c6825e"),
				Name = "Dogslicer",
				Price = 10,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("d890d59a-a9bf-410b-b37e-0bf6c2e296ce"), "This short, curved, and crude makeshift blade often has holes drilled into it to reduce its weight. It's a favored weapon of goblins.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("58ea8b2a-0cf5-4644-969e-cbc3c142e17a"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("39954bd1-2e87-4fa6-8d1a-53c276fc348a"), Traits.Instances.Backstabber.ID);
            builder.Add(Guid.Parse("c05793d4-1f3c-4548-8e1b-5e885e2fbd73"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("0888fe84-5f71-4325-967e-16860605fe43"), Traits.Instances.Goblin.ID);
            builder.Add(Guid.Parse("302ccd93-d1a9-406c-9233-8fa5b0d7aa4f"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40e2f952-2c1f-4043-8f43-8c4f9f56a6bf"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
