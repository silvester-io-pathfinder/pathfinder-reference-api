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
    public class Guisarme : Template
    {
        public static readonly Guid ID = Guid.Parse("164fced7-fbaa-4e79-8eb2-5ea61cfa4f5e");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Guisarme",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Polearm.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("0f0c3473-93b7-4121-b77f-88d13f9253b6"),
				Name = "Guisarme",
				Price = 200,
				Hands = "2",
				Damage = "1d10",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("c20e4af4-d330-402e-b76f-4d0426094780"), "This polearm bears a long, often one‑sided, curved blade with a hook protruding from the blunt side of the blade, which can allow its wielder to trip opponents at a distance. Its shaft is usually 8 feet long.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("aa31d7f7-c721-439a-8627-50a663773397"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("191fcf34-7305-4da4-9027-c5ce427e45b0"), Traits.Instances.Trip.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad92e182-3b2f-4b0a-80c2-b3d8fa404015"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
