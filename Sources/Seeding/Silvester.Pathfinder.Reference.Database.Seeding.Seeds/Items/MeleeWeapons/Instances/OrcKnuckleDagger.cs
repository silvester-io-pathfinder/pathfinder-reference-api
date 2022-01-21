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
    public class OrcKnuckleDagger : Template
    {
        public static readonly Guid ID = Guid.Parse("43f6b330-380e-4767-be1f-a49120d115c8");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Orc Knuckle Dagger",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("3be23cc1-d918-48da-95b9-534a57989e65"),
				Name = "Orc Knuckle Dagger",
				Price = 70,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("2590f7bf-d5a9-4502-8229-11aa42da1713"), "This stout, metal blade of orc design has a horizontal basket hilt with blades jutting from each end, or sometimes one blade like that of a katar.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4d3aadbd-59cb-49e3-a0a2-b51f48cb55d4"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("9ab77270-6198-47e3-9097-2fd0b7e662d8"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("8675f3a0-1c76-4e25-8881-9c21ee4f12f9"), Traits.Instances.Orc.ID);
            builder.Add(Guid.Parse("93fe5ca3-7cd8-49aa-80d5-dc30553fac86"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae55b9c2-c9ee-4d71-9e74-31e1717845a9"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
