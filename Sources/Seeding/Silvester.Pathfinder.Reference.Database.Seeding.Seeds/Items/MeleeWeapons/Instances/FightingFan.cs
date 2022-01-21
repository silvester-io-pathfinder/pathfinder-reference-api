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
    public class FightingFan : Template
    {
        public static readonly Guid ID = Guid.Parse("3b7c5c1b-8be2-4152-bae1-475f9853919c");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Fighting Fan",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("3c8da955-decb-4236-9a0b-834b0afcd507"),
				Name = "Fighting Fan",
				Price = 100,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("c5ece34c-23d3-4cd8-928a-5da16e2ce986"), "This fan is useful for elegant dances as well as for slicing unsuspecting foes with the blades along its outer edge. If used in performances, it might be disguised as a frilly accessory, or it might be an obvious, though elegant, weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7d9c8c39-1cab-4ef6-8f84-47102b6ab5bf"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("1e215127-177c-4d84-8eba-36897c9d6611"), Traits.Instances.Backstabber.ID);
            builder.Add(Guid.Parse("580ac305-6584-4a6e-8dd4-807b44f642eb"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("5a7c0596-f6b5-4a75-adf5-87c7554df92c"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("ea84058f-1f41-41d7-9691-cbc5a85381f1"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("0db185a1-eae3-40c8-a865-328ac5752859"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8013ef6-44c3-4d26-9818-3723d71e995d"),
                SourceId = LostOmensGodsAndMagic.ID,
                Page = 120
            };
        }
    }
}
