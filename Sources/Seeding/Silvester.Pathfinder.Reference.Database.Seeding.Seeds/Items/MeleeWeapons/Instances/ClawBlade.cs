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
    public class ClawBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("f5a772c0-8d78-4073-9b73-4b4c9fc8fbe3");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Claw Blade",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("c37f6535-c892-4b53-beb4-c5ad9c484a2e"),
				Name = "Claw Blade",
				Price = 200,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("c3fd2d41-bf04-4dd6-aff5-c1d2e39de9e5"), "The three parallel blades of this handheld weapon extend between the fingers to resemble the natural claws of the amurruns who created them, providing a way for those catfolk without suitable natural claws to share the fighting customs of their kin.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e330c81a-bedc-49c4-b26f-eaced91d91c2"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("054aa79f-ea73-4b11-a4b0-a48a9edbde99"), Traits.Instances.Catfolk.ID);
            builder.Add(Guid.Parse("92ff408d-cb55-46a3-94f0-6f3019cbe64e"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("28bc90a5-e387-4845-90da-67b9dc29b999"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("7892c789-10ab-49f2-bb18-d6572a6e1de5"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("08408238-e2bd-4941-a30d-a18e091ab8a9"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f2493c1a-31e4-4ab7-9051-330f50ba1c6b"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e11bd8a-0f5e-4de1-82b3-896568dbc2d1"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 248
            };
        }
    }
}
