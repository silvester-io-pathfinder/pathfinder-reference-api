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
    public class SwordCane : Template
    {
        public static readonly Guid ID = Guid.Parse("32548452-7334-4260-b729-00272a3bd933");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Sword Cane",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("11b930c5-47d0-4349-92ae-f0fd8083cbd1"),
				Name = "Sword Cane",
				Price = 500,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("d0122382-d0b7-4c61-a2bb-e1f86611d40c"), "This slender, rapier-like sword is concealed within a wooden or metal cane that serves as a sheath, making it an inconspicuous weapon easy to slip past inspections or into high-society events. A sword cane is typically 4 feet long when sheathed, and its hilt is usually capped with a wooden or metal decoration.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("eaf5a726-a1ba-420f-8c68-724e73befd3b"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("6d9392e8-20a0-4461-8633-8bdd737dbc0c"), Traits.Instances.Concealable.ID);
            builder.Add(Guid.Parse("5cd280b5-3e6a-4af2-a156-19fce7dc689e"), Traits.Instances.Finesse.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a469cd6-e92f-40c6-b7ee-916e412414b3"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 248
            };
        }
    }
}
