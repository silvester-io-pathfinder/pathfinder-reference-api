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
    public class WarRazor : Template
    {
        public static readonly Guid ID = Guid.Parse("290046a3-6eac-414f-8374-d046ee27cfe9");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "War Razor",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("ac3e466a-5946-4611-bea2-8969fe047032"),
				Name = "War Razor",
				Price = 30,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("466d5fad-df5c-4d7c-84e0-cbdb70df6dfe"), "A war razor is an exaggerated version of the barbers' tool. It is a brittle but extremely sharp weapon that is very easy to slip into a pocket or sleeve.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("697702cc-99c0-48d0-b10d-00185f8180fe"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("53cadf11-436d-42cf-ae48-4860f176e279"), Traits.Instances.Backstabber.ID);
            builder.Add(Guid.Parse("46ade9ef-dd4f-4ee1-be98-5f173201c9b1"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("72fc1af7-bdbb-4bc9-8254-eca29e79dd10"), Traits.Instances.Finesse.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d6a40c9-a864-4894-8d86-bba7d33c0dce"),
                SourceId = LostOmensGodsAndMagic.ID,
                Page = 121
            };
        }
    }
}
