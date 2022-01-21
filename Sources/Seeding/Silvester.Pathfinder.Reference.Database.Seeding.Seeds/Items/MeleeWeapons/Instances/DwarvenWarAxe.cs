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
    public class DwarvenWarAxe : Template
    {
        public static readonly Guid ID = Guid.Parse("d0b1390b-25b4-4302-91e0-4c80963125ce");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Dwarven War Axe",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Axe.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("e6c0105e-106e-45f7-a021-408ce7218048"),
				Name = "Dwarven War Axe",
				Price = 300,
				Hands = "1",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("e582783c-03bd-41c1-ac94-3b6349ee7e8b"), "This favored weapon of the dwarves has a large, ornate head mounted on a thick handle. This powerful axe can be wielded with one hand or two.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("898aaba7-e9c9-4518-a42e-555244724e78"), Traits.Instances.Dwarf.ID);
            builder.Add(Guid.Parse("1f0e9494-02c0-403d-a978-f01bdc857011"), Traits.Instances.Sweep.ID);
            builder.Add(Guid.Parse("5a09516c-6d29-463f-90e6-7e2957bc5838"), Traits.Instances.TwoHand.ID);
            builder.Add(Guid.Parse("c2556e65-a8c8-4276-bbdf-e9f0ffc91bfb"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("23fd9739-93e5-4241-aaaa-4160682f213a"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
