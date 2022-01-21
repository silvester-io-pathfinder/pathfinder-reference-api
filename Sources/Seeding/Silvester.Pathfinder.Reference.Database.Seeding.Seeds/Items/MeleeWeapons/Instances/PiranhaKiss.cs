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
    public class PiranhaKiss : Template
    {
        public static readonly Guid ID = Guid.Parse("44b32696-6172-4503-9275-453e694c178f");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Piranha Kiss",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("2fb1f744-680f-4f6d-8e12-89f3c142aa77"),
				Name = "Piranha Kiss",
				Price = 40,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("dd40a8dd-886f-480d-83c8-734415723f01"), "Made of a jagged blade with teeth pointing toward a leather-wrapped hilt, these weapons are particularly effective at disarming opponents. Piranha kisses were occasionally used during the Vidric Revolution, and some Firebrands carry them today.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c5067988-dcad-4a70-ba7c-0ea43ad03b52"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("2e013737-02c0-44d6-9e50-f95b22e50f2e"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("6739e9ee-a7f1-4dc8-821c-9de962940b45"), Traits.Instances.Finesse.ID);
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14f1ef8f-3995-45d5-ab6d-4e607871dc81"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 106
            };
        }
    }
}
