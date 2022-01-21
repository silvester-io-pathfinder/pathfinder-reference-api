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
    public class Naginata : Template
    {
        public static readonly Guid ID = Guid.Parse("cea48192-0fda-4dc9-a0ec-5df4ea926d35");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Naginata",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Polearm.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("baac0f13-869f-4af5-a9a6-8d2e509daf84"),
				Name = "Naginata",
				Price = 300,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("193443cb-792c-4d53-bed9-8cc18198ae9c"), "This 6-foot staff has a 2-foot-long, slightly curved, swordlike blade attached at one end. The long pole helps keep the wielder out of reach of swords and shorter weapons.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1f5b0484-7f2d-4728-b02b-2b6ca9105f2d"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("09eaf1a6-aa4e-429d-8a77-2ff5c41f81ef"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("fefb9a3c-89a0-4a5a-95f6-f5c7253465d3"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("deea3102-659f-4cdc-9610-384e736685c1"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3653698-fe26-4e9d-a5ac-d528f42c6375"),
                SourceId = LostOmensGodsAndMagic.ID,
                Page = 121
            };
        }
    }
}
