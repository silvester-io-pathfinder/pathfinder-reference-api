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
    public class DuelingPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("ba0843a3-8bf7-4871-9430-40bb709cd1e8");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Dueling Pistol",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("eb95e037-5786-4ba3-adbe-e9355f29d3ea"), "Made for settling disputes when diplomacy fails, dueling pistols are finely crafted and made to fit easily into a holster or pocket. Noble and wealthy merchants in both Alkenstar and Dongun Hold often own matching pairs of dueling pistols in case they�re called upon to address a challenge�though this practice has become increasingly rare in the modern age.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("039239d8-1520-40eb-99bf-63c709543ec4"),
				Name = "Dueling Pistol",
				Hands = "1",
				Price = 1200,
				Reload = 1,
				Range = 60,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9c061d97-dc8e-42c3-b459-7e1f0ad578aa"), Traits.Instances.Concealable.ID);
            builder.Add(Guid.Parse("06e321b0-ca94-41b0-a4b3-7e070258f470"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("b5b80584-9406-449b-9a6f-234167bbac39"), Traits.Instances.Fatal.ID, "d10"); 
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cec8923-efd4-4be7-846b-6e13469705e7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
