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
    public class Fauchard : Template
    {
        public static readonly Guid ID = Guid.Parse("875d97cc-2d8f-4498-8659-00251e3f969c");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Fauchard",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Polearm.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("e03e4af8-4532-4b00-bd5e-b5837420d1c9"),
				Name = "Fauchard",
				Price = 100,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("c90bfb40-acfb-46fb-87c9-fb3629dd5e63"), "A fauchard is similar to a glaive, save that its cutting edge is along the concave side. Fauchards are favored by Crimson Reclaimers for hacking through waves of zombies. The fauchard is a martial melee weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("57a06e23-f337-45c0-90c5-8bac5da07f01"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("6fc8fceb-a143-4b92-8e23-f50f6802069d"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("cf55f1b9-ff96-4c08-a872-3e0b71a56f84"), Traits.Instances.Sweep.ID);
            builder.Add(Guid.Parse("409280d4-269c-4d45-98be-9fe3fe54d307"), Traits.Instances.Trip.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2084884d-e0ed-4656-ab81-14730a7d2607"),
                SourceId = CharacterGuide.ID,
                Page = 92
            };
        }
    }
}
