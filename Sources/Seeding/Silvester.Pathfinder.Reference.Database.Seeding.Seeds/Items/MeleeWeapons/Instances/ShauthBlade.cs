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
    public class ShauthBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("e3996bab-ff49-45d2-a295-c46fe7347717");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Shauth Blade",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("8a1702f3-20c9-4be3-8adb-f787bc396335"),
				Name = "Shauth Blade",
				Price = 200,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("97dde2b0-0de6-49fd-8e9b-b4fa012c4f07"), "These strange curved blades are jagged and deadly weapons made from the alchemically strengthened teeth of dead urdefhans. Each weapon is typically named for the urdefhan whose teeth were forged into the weapon, which are often carried (and revered) by that urdefhan's descendants. Magical shauth blades allow an urdefhan wielder to channel their Wicked Bite ability through shauth blade Strikes.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("949d8843-dcea-43cf-8837-d426a283cbd2"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("4176ada4-d7dd-446b-a4c6-070f0283e131"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("d3cbe7c3-8f4b-4b4c-a86b-450c0e05031a"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("3586aac7-6111-44ed-87bc-953c21cbed5c"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("29e1b411-18f9-4f3e-855c-b3eca9788e9b"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82483b0d-8bf1-4be2-a629-7d51914ce120"),
                SourceId = Pathfinder165.ID,
                Page = 73
            };
        }
    }
}
