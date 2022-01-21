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
    public class UmbrellaInjector : Template
    {
        public static readonly Guid ID = Guid.Parse("5691f816-e466-4196-b698-8f6ecf79359c");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Umbrella Injector",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("8df3a643-fb71-4059-bd33-728de1b9fe84"),
				Name = "Umbrella Injector",
				Price = 400,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("3be995cb-07f6-48f3-9de1-fb49b9ff1da4"), "This umbrella's ferrule is a hollow-tipped blade three to four inches in length and often overlooked as decorative. A receptacle inside the umbrella's shaft can be loaded with a single dose of injury poison and injected into a damaged target with the pull of a sliding trigger. Reinforced ribs enable you to parry and deflect blows with the umbrella's tear-resistant canopy.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("16eae997-bf6e-41fa-826e-89f32f2f0c9d"), Traits.Instances.Concealable.ID);
            builder.Add(Guid.Parse("7705ec95-6c2d-46f1-a35e-6c57b60588ad"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("2fe1f269-a33a-43e2-a45f-cf2a1b924a1a"), Traits.Instances.Injection.ID);
            builder.Add(Guid.Parse("33f8b5ff-e663-4cac-8216-0a5976336a92"), Traits.Instances.Parry.ID);
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3187915f-0bd5-44ce-9cd1-954a7e4f1aaa"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 64
            };
        }
    }
}
