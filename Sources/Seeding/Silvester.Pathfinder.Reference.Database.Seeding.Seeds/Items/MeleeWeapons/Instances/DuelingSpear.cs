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
    public class DuelingSpear : Template
    {
        public static readonly Guid ID = Guid.Parse("ab7ca8ac-2df3-4cda-bcfe-686ef8ea391c");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Dueling Spear",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Spear.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("9248e376-5f84-4d06-a648-abee6cd554d9"),
				Name = "Dueling Spear",
				Price = 200,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("a3d7008c-69a0-418d-a195-33cb763e4919"), "This spear has a spade-like blade at one end and a forked blade at the other, making it resemble a large arrow. It's well balanced for spinning and twisting maneuvers. The spade-like end can be used for slashing and stabbing, while the forked end is effective at wrenching a weapon from an enemy's grasp.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b2de3681-8d35-4a4f-81a8-1a9b1b049670"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("dde695b1-c880-42f7-8949-7cf079f8508e"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("9eddf9ee-e495-446b-9966-61000abe66ff"), Traits.Instances.Versatile.ID, "S");
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c9d618d-e91b-4263-ad9d-52a13fd16327"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 105
            };
        }
    }
}
