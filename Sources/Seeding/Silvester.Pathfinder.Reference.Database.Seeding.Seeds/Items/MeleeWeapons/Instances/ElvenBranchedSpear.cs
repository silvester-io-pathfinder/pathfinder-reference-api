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
    public class ElvenBranchedSpear : Template
    {
        public static readonly Guid ID = Guid.Parse("ac509c60-bb6a-455f-8682-3db07882f9b8");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Elven Branched Spear",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Spear.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("597cb342-6f16-4999-9f33-feb74cf58ea4"),
				Name = "Elven Branched Spear",
				Price = 300,
				Hands = "2",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("7585b337-8391-4d1a-8816-8c679986072f"), "Several short branches project from this delicate spear's shaft, each angled forward and tipped with a leaflike blade.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0960256f-85f1-46bc-b563-620fbc8aa988"), Traits.Instances.Deadly.ID, "d8");
            builder.Add(Guid.Parse("ac1a744d-9738-47ed-9a5b-b58c7ccf3bf1"), Traits.Instances.Elf.ID);
            builder.Add(Guid.Parse("f08ad19e-a86c-497a-b3b0-38c69c8d89e8"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("9aab0f2b-6898-4a35-b939-61a5a7429548"), Traits.Instances.Reach.ID);
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb2e0cf0-d981-4119-8327-75ba134c91cd"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 105
            };
        }
    }
}
