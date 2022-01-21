using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class AirRepeater : Template
    {
        public static readonly Guid ID = Guid.Parse("878342e4-cdd7-4252-b2a7-266a7a6950aa");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Air Repeater",
                WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("096820b6-05f9-4096-bb7d-84a36f1bcb6e"), "A thin-barreled firearm that uses a container of pressurized air instead of black powder to propel small metal bullets from an attached cartridge, the air repeater has fallen out of common use in Arcadia due to its poor stopping power, though it�s still used occasionally for casual hunting and sport shooting. The air repeater and its longer-ranged, two-handed variant are still valued by some for their ability to allow a shooter to fire multiple rounds without needing to stop to reload or crank to a new chamber. A typical air repeater magazine holds 6 pellets.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("9aaf62d9-3615-4e33-98df-ffac9f25368e"),
				Name = "Air Repeater",
				Hands = "1",
				Price = 500,
				Reload = 0,
				Range = 30,
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3ada939d-3e51-4ca3-aa7f-eb5a2dc1009b"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("03b07f2d-f305-41c5-a1ec-cc6aa96ab43e"), Traits.Instances.Repeating.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5686e803-4b34-49a9-8e2b-47bc3079f0b1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
