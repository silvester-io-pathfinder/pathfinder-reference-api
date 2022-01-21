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
    public class AldoriDuelingSword : Template
    {
        public static readonly Guid ID = Guid.Parse("412f2018-c2f7-493f-b213-8fe8ca14b7ff");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Aldori Dueling Sword",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("8863b408-fe8f-4479-9d45-bf179fba2995"),
				Name = "Aldori Dueling Sword",
				Price = 2000,
				Hands = "1",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("9993cba4-1ad7-4099-9569-3d12766d9fe3"), "An Aldori dueling sword is a slim, single-bladed dueling sword with a slight curve and a sharp, reinforced point.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("00349643-43d8-443d-b0f5-0c21262f0b1f"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("e50ee1ed-2a41-4948-ae15-6cf026566368"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("9aa43065-4dc0-41f5-be9f-2c5a189b138e"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a533ae3-a77e-4c69-8d1f-f65ca2ef0042"),
                SourceId = WorldGuide.ID,
                Page = 28
            };
        }
    }
}
