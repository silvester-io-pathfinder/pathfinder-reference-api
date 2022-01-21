using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class Arquebus : Template
    {
        public static readonly Guid ID = Guid.Parse("b9c0dfbd-b582-48a7-8274-f38e474fd033");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Arquebus",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ff4a28fc-c21c-4f6f-afb5-df7474ec3a77"), "This is a long rifle that offers more range than the average firearm, though the long barrel and ferocious kickback make the weapon particularly unsteady unless a tripod or other stand is used to stabilize it. The arquebus is one of the most commonly used long guns among the soldiers of Dongun Hold and Alkenstar.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("97ca531c-b144-414c-9549-3e6c0e52897e"),
				Name = "Arquebus",
				Hands = "2",
				Price = 1000,
				Reload = 1,
				Range = 150,
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9df512b9-ee77-4b64-a747-7835db184a9a"), Traits.Instances.Concealable.ID);
            builder.Add(Guid.Parse("c84e2d4e-517f-482a-beb1-ceccb76e2b9b"), Traits.Instances.Fatal.ID, "d12"); 
            builder.Add(Guid.Parse("35eeff8c-8f17-4cab-ae96-b613a0e2ffee"), Traits.Instances.Kickback.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24a5ba56-416b-47be-95b9-fa61b74f8325"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
