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
    public class LightMace : Template
    {
        public static readonly Guid ID = Guid.Parse("b40cb041-7b1c-49fc-8c54-8b66afce34ae");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Light Mace",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("504ec1ac-5ade-4735-923a-0751b4a7a41e"),
				Name = "Light Mace",
				Price = 40,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("426a3768-50cf-49e3-b619-706a994fcc17"), "A light mace has a short wooden or metal shaft ending with a dense metal head. Used much like a club, it delivers heavy bludgeoning blows, but with extra power derived from the head's metal ridges or spikes.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("adc062bf-017d-4867-aaa8-6670c78b5477"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("16f3bc76-6593-4a32-bfe2-70bd4a806725"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("421b64c5-6616-484a-be46-e4f5ba673128"), Traits.Instances.Shove.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42c099df-55ea-40f8-81c5-6dfca855bbf2"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
