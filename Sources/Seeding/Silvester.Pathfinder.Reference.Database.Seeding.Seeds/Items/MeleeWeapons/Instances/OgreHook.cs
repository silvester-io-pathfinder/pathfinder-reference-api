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
    public class OgreHook : Template
    {
        public static readonly Guid ID = Guid.Parse("5249b6ac-9cf9-4a95-9e28-e13f50cbc473");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Ogre Hook",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Pick.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("f6e055cc-0c2a-4cb1-b7b2-1f3baa52b86f"),
				Name = "Ogre Hook",
				Price = 100,
				Hands = "2",
				Damage = "1d10",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("8288bca2-6880-4bf6-8504-714d1ff2e288"), "Ogres are known for using immense, curved picks called ogre hooks.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("661ba486-4a18-477f-a7c6-c04ff2ae7b52"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("8781fca4-4ba5-4145-bf0a-c603d68d6b68"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("b96a8efc-05c0-42d1-ab55-cbc8ce78c04f"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7830364d-bfa3-48a4-9848-3bb4f19de2b8"),
                SourceId = Bestiary.ID,
                Page = 253
            };
        }
    }
}
