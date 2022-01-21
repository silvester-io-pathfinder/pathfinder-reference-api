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
    public class ButterflySword : Template
    {
        public static readonly Guid ID = Guid.Parse("4d47aff7-8e1d-4a71-89f6-aec418acef67");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Butterfly Sword",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("acd53cac-8c0a-499a-99d0-244e04d61ce7"),
				Name = "Butterfly Sword",
				Price = 20,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("289ffd6d-8bd9-4a55-8d9a-0dcd22d4726e"), "This short, single-edged sword typically features a cross guard that helps catch oncoming attacks. It is the preferred weapon of Butterfly Blades—highly skilled Gokan assassins.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c2f61d74-53a8-4676-a5f8-c42424ba0c8d"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("964f7c12-817b-419d-8e4a-177d10789c07"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("76703841-e031-476e-9c84-5d419b488d04"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("f4e4ee94-eab9-4ce1-a841-d182c425ead3"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("82f0f5c0-74f5-499c-bc90-7f7506d25339"), Traits.Instances.Parry.ID);
            builder.Add(Guid.Parse("4c7d76b6-3692-46a9-be5e-758371e21299"), Traits.Instances.Twin.ID);
            builder.Add(Guid.Parse("c7c0ed4f-a0ca-435a-8833-f8547c9860f8"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63775341-f3b9-43bd-bbbc-c395812258d8"),
                SourceId = Pathfinder166.ID,
                Page = 280
            };
        }
    }
}
