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
    public class MainGauche : Template
    {
        public static readonly Guid ID = Guid.Parse("353d5fd0-a2b2-4676-a661-7238de6fe7c4");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Main-Gauche",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("80bf3bc7-81ac-46a1-b9fc-3567b10ce9a5"),
				Name = "Main-Gauche",
				Price = 50,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("92250591-466a-4c5e-b82f-7466dcaf05e4"), "This parrying dagger features a robust guard to protect the wielder's hand.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("15cdabe4-7643-4e07-ae72-bc08ce1f8d5e"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("ab6c1f2b-e5f1-49ed-881c-24a63ba52195"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("7b2723b7-abbe-4d19-b7a3-ef9b748f2621"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("2b9b1cd2-8c37-4301-b267-7f9d07527ee0"), Traits.Instances.Parry.ID);
            builder.Add(Guid.Parse("b05e71c9-e5ad-431a-afd9-b674f6557b9c"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c43594c0-daf3-44c1-a8b7-3753a0f6a089"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
