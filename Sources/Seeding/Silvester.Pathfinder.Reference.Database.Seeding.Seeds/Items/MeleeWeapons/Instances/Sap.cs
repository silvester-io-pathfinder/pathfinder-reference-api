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
    public class Sap : Template
    {
        public static readonly Guid ID = Guid.Parse("3f70b226-d857-45b6-9c37-6e00155566c5");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Sap",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("27fb010e-1590-4718-a70f-962ff2b769cf"),
				Name = "Sap",
				Price = 10,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("0ec195bd-e2f7-4234-9c22-4021cec0058e"), "A sap has a soft wrapping around a dense core, typically a leather sheath around a lead rod. Its head is wider than its grip to disperse the force of a blow, as the weapon's purpose is to knock out its victim rather than to draw blood.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("bd4d7a98-0258-48e5-ad73-c1a53819aad0"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("e2cbadf8-2a0d-42cb-be95-4b4ffad54695"), Traits.Instances.Nonlethal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff40af4d-5cff-4673-99c5-b7425edc948a"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
