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
    public class ExquisiteSwordCaneSheath : Template
    {
        public static readonly Guid ID = Guid.Parse("3705d218-3b4f-4849-a69b-a04b0b94fa96");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Exquisite Sword Cane Sheath",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("e90874e3-0935-4811-ab6e-cfebc270f93a"),
				Name = "Exquisite Sword Cane Sheath",
				Price = 0,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("18ffa77d-fa14-4c0d-ace7-1976387c74c8"), "An exquisite sword cane is a sword sheathed inside a hollow cane, which itself can be used as a clubbing weapon with or without the sword sheathed inside.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6e93c6fa-9476-4cc1-9cc9-6951b8cadb07"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("81881142-4f92-4a48-b3af-0913da6cad55"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("a42d24db-8c59-46ba-ad48-9ca1e4889f48"), Traits.Instances.Parry.ID);
            builder.Add(Guid.Parse("ab1ab845-9dab-4fe1-b6a5-0f210c9a9759"), Traits.Instances.Twin.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c07999f-a858-4646-be52-c7c6655b47e1"),
                SourceId = Pathfinder157.ID,
                Page = 80
            };
        }
    }
}
