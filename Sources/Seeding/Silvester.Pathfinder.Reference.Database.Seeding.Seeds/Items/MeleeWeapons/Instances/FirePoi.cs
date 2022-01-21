using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class FirePoi : Template
    {
        public static readonly Guid ID = Guid.Parse("af5dff58-65ad-402e-b78c-4cc9eee8e126");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Fire Poi",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("8b8fca7f-18e0-4f1c-9f64-cebcc970be9f"),
				Name = "Fire Poi",
				Price = 500,
				Hands = "1",
				Damage = "1d4 B + 1d4 F",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("fb91a8a3-c5e9-4ef3-bea5-e93f28196e3b"), "These special poi are made from a rare, light metal or from fire-retardant fibers and can be ignited before being wielded. Igniting a pair of fire poi is an Interact action and requires 1 pint of oil for every 10 minutes the poi remain ignited. While lit, fire poi cast dim light in a 10-foot radius; in combat, they deal 1d4 bludgeoning plus 1d4 fire damage. On a critical hit with a lit fire poi, the target takes 1 persistent fire damage. The fire can be extinguished using the Interact action. When unlit, the poi deal only the listed bludgeoning damage. Regardless of whether it is lit, the poi's 1d4 bludgeoning damage is the weapon damage dice, so striking runes and other effects don't affect the fire damage.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("68160a11-9c32-439b-8a06-9b6eec11e15c"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("75013150-eaf7-4a4f-930d-d16232d1105d"), Traits.Instances.Backswing.ID);
            builder.Add(Guid.Parse("af308016-f66d-4ab1-a3ca-9179cfd555e6"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("3fd61d7d-d66c-4072-a110-7c2e99d618fb"), Traits.Instances.Twin.ID);
            builder.Add(Guid.Parse("d4cac013-750c-41b8-af2c-87fc6458f45e"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6339002f-07a7-4021-a557-3d7bc6c3a120"),
                SourceId = Pathfinder151.ID,
                Page = 77
            };
        }
    }
}
