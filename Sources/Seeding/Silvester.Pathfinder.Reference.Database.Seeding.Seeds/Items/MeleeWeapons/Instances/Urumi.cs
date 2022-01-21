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
    public class Urumi : Template
    {
        public static readonly Guid ID = Guid.Parse("c6ef5724-8aff-41b3-b15d-dc83efc1299f");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Urumi",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("61f8509f-66a0-43fa-8ae9-312dde387ebc"),
				Name = "Urumi",
				Price = 200,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("4e81f39e-556d-42fd-8514-7fda48d1c9cb"), "A bouquet of whiplike blades extends from the hilt of this sword.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d01d63fb-bb3c-46b8-bc02-52b67fd23b2a"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("3d617bd6-0b9e-4b12-96f9-74f92c63f341"), Traits.Instances.Sweep.ID);
            builder.Add(Guid.Parse("54d77cd7-7eb8-462e-ae6d-a9a35bf26fd5"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc09c8b5-2efa-486a-b01b-9319085183f9"),
                SourceId = LostOmensGodsAndMagic.ID,
                Page = 121
            };
        }
    }
}
