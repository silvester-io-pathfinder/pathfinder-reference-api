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
    public class ThrowingKnife : Template
    {
        public static readonly Guid ID = Guid.Parse("8c5fdda9-9bf1-44e1-9999-f09671d25abc");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Throwing Knife",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("053eefe7-ae3c-48d6-b2ac-3e8410eb5704"),
				Name = "Throwing Knife",
				Price = 30,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("6d377af9-f8d8-43ab-bdbf-146b95882c47"), "This light knife is optimally balanced to be thrown accurately at a greater distance than a common dagger. While this comes at the cost of a significant cutting edge, the difference is worth it for characters focused on thrown weapons.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7f3ce15e-b8a5-4402-93a5-ac959e29a61f"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("ec0bb750-8756-439f-85ee-ab8ee587199a"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("a812caf0-bae2-4bf7-953b-fcc0d1de43bf"), Traits.Instances.Thrown.ID);
            builder.Add(Guid.Parse("bc8c09c5-fb4b-4087-89d5-1cfa7b3c5df9"), Traits.Instances.Twin.ID);
            builder.Add(Guid.Parse("166f2807-3485-4a36-bdd9-d11d19bb0824"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea303bb0-d017-41a3-b9c3-58b6dc4cce0a"),
                SourceId = Pathfinder151.ID,
                Page = 77
            };
        }
    }
}
