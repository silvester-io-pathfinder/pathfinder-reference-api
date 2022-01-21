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
    public class InjectionSpear : Template
    {
        public static readonly Guid ID = Guid.Parse("4cf9626c-e1bc-4e89-83e5-563d35720217");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Injection Spear",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Spear.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("d96b41e9-945a-492c-b711-51d6e2501431"),
				Name = "Injection Spear",
				Price = 300,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("d49c1bbc-123f-4602-a94b-e0de4d579dcb"), "A hollow receptacle inside this spear's head can store a single dose of poison. A sliding trigger along the spear's shaft can inject the loaded poison into a damaged target.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("71f3c713-c6b4-471a-bce7-d8b10f484428"), Traits.Instances.Injection.ID);
            builder.Add(Guid.Parse("3a468d79-4b72-4031-86aa-9b1ce775c5cb"), Traits.Instances.Reach.ID);
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8145c46c-0460-4257-98b8-06f5ae29ab92"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 63
            };
        }
    }
}
