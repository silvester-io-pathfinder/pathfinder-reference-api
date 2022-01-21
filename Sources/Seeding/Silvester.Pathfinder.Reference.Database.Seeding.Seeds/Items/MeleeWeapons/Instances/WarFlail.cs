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
    public class WarFlail : Template
    {
        public static readonly Guid ID = Guid.Parse("551297c6-7253-4b20-aa41-d290ed14cb26");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "War Flail",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("5ce26ec1-5ffb-48b7-9a47-91fa0d449b16"),
				Name = "War Flail",
				Price = 200,
				Hands = "2",
				Damage = "1d10",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("284a5ed3-cba3-4ff4-911b-7b655f465db5"), "This large flail has a long shaft connected to a shorter piece of stout wood or metal that's sometimes inlaid with spikes.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("511332b3-32c6-45b4-b8c7-e41adab3d575"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("6f49c157-b983-4aef-a6e4-a0fecd0bd1be"), Traits.Instances.Sweep.ID);
            builder.Add(Guid.Parse("f715305b-51d8-4554-ae87-074e001e9ef3"), Traits.Instances.Trip.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bb4957d-2781-4ee2-9b04-2b0f1a0123e4"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
