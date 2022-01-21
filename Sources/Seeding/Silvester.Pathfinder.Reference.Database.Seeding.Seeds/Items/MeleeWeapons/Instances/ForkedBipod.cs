using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class ForkedBipod : Template
    {
        public static readonly Guid ID = Guid.Parse("2249450c-41c3-4a9b-b98f-bc0026dd8dea");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Forked Bipod",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Spear.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("51080f16-539e-45a8-a927-39400bc50f6a"),
				Name = "Forked Bipod",
				Price = 30,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("2aa0489d-4439-44b2-85f3-7beb6f1f2afc"), "Developed by Alkenstar scouts who often don�t have time to break down a tripod when beset by the chaotic mutant monsters of the Mana Wastes, this two-pronged stabbing weapon can be used as a bipod to stabilize a gun with potent kickback. A forked bipod can be deployed or retrieved for use as a melee weapon as an Interact action.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6245a71c-6ae1-4a4a-8406-e3a70e8d9ddc"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("bb795aa2-a075-46f6-966e-796bd5b7a229"), Traits.Instances.Deadly.ID); //TODO: d6
            builder.Add(Guid.Parse("8028890c-a435-4d9b-a979-ea867b78cca4"), Traits.Instances.Finesse.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdebd19a-5562-4919-a526-48d008666f01"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 150
            };
        }
    }
}
