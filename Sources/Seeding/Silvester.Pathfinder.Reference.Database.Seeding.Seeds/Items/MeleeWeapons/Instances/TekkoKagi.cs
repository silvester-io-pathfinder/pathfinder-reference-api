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
    public class TekkoKagi : Template
    {
        public static readonly Guid ID = Guid.Parse("32823fbd-8598-4fc3-a9d9-769043cbce0f");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Tekko-Kagi",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Brawling.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("2232825b-185a-4731-88e9-4435f21a55e8"),
				Name = "Tekko-Kagi",
				Price = 20,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("e070731d-b127-4713-a03a-bb669ccedfb9"), "Four curved blades attached to a sturdy handlebar give the wielder of this close-combat weapon the illusion of having claws that extend from their fist. Adherents of Bastet favor the tekko-kagi for catching their foes off guard.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f3728539-4f65-4867-92ab-959aa31e0528"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("dc3faabd-6c77-4ddf-8d78-d56dc0359c72"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("87e0bd15-cf9d-4c30-a589-c42c1c6373ca"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("6ffef326-bdb1-405f-bdc0-04bff9d1dafd"), Traits.Instances.Parry.ID);
            builder.Add(Guid.Parse("08dfb2a1-47ce-4fbe-9f6a-9c751d8db030"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("e6aed9da-bb0b-4364-9844-8d991efce6eb"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d59eec71-20e8-49a6-82d4-9e5b309fa763"),
                SourceId = LostOmensGodsAndMagic.ID,
                Page = 121
            };
        }
    }
}
