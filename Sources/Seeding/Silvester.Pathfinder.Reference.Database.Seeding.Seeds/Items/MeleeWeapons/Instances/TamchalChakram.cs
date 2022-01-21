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
    public class TamchalChakram : Template
    {
        public static readonly Guid ID = Guid.Parse("4ac6f2cd-6fc3-400f-b524-fdaeaaaca2bc");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Tamchal Chakram",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Dart.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("cbea519c-81f1-4267-9261-b8410c339c51"),
				Name = "Tamchal Chakram",
				Price = 500,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("c2f31576-2cfe-4c61-ba90-e043f982ede9"), "These circular weapons are among the many strange weapons used by urdefhans. The sharp metal circle contains numerous protruding blades, while an angled central handle provides a decent grip that spins the weapon as it's thrown.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4db4f9cc-e7bb-4cf8-9a2b-19f96890fa1f"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("64e38b40-5e00-4531-99c9-ab5fad601a4d"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("a5f0a34c-6b9a-4a71-8c82-e7240bf11f9c"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("7911fdbe-4bd6-4e63-957a-186ef2935b8d"), Traits.Instances.Thrown.ID);
            builder.Add(Guid.Parse("077e4d96-0f0c-4cdd-ab70-860b7432f3d9"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08b2d76c-3dd8-434f-be2e-87ab70369e8b"),
                SourceId = Pathfinder164.ID,
                Page = 73
            };
        }
    }
}
