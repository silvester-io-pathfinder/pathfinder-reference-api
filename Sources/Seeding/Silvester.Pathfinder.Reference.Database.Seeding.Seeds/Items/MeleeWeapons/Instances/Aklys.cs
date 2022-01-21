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
    public class Aklys : Template
    {
        public static readonly Guid ID = Guid.Parse("24f52641-1737-4761-8576-66710f258aab");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Aklys",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("57bfa74f-ea7f-4192-b89a-de4d3eb80922"),
				Name = "Aklys",
				Price = 500,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("3c249bdf-b09f-4fe5-b9c8-8068629c3c22"), "The aklys is a throwing club with a hook on one end and a lengthy cord attached to the other. Though aklyses aren't available in most shops, one might be purchased for 5 gp from a vendor that specializes in strange weapons.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("265f8bda-b6ea-4b2a-9bda-a3dacada40df"), Traits.Instances.RangedTrip.ID);
            builder.Add(Guid.Parse("2725bcef-5827-41f8-9914-9559bd814b58"), Traits.Instances.Tethered.ID);
            builder.Add(Guid.Parse("77f01e70-c5eb-4b43-8a41-657a1cceceb9"), Traits.Instances.Thrown.ID);
            builder.Add(Guid.Parse("557c82fe-d8a5-408f-b3ed-b4bd33b6de8b"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("d1564096-f560-4505-bfb4-e2a5193c98e8"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f87e5121-6a39-400e-898d-8a8e50faedba"),
                SourceId = Bestiary.ID,
                Page = 85
            };
        }
    }
}
