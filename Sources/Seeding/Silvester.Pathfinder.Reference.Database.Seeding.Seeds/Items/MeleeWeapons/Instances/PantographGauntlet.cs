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
    public class PantographGauntlet : Template
    {
        public static readonly Guid ID = Guid.Parse("b56dbf2a-9264-4677-900c-6bb2e4c2cf6a");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Pantograph Gauntlet",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Brawling.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("74b7bc8d-1643-468c-8024-f03a1223ec9d"),
				Name = "Pantograph Gauntlet",
				Price = 200,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("c80c1418-a194-4ff8-b7ce-97245c4325a5"), "A pantograph gauntlet is a heavy, fist-like weight, mounted on an extendable frame and attached to your outer arm with a series of leather straps. The frame's set of mechanical linkages connected at various hinges allow movements to propagate across the frame based on reshaping parallelograms, further controlled by a crossbar grasped in your hand. A pantograph gauntlet is driven by your own motion and mirrors your arm's movements - a punch thrown with your fist moves the pantograph, extending the weight out at a rapid speed to land blows up to 10 feet away. In some regions, such as Alkenstar and Ustalav, pantograph gauntlets are occasionally constructed entirely of metal and fashioned in the likeness of oversized arms, incorporating a complex system of gears or a miniature steam engine in place of the simpler pantograph mechanism.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e0cf9c45-a962-4f59-91c7-272c7a55a197"), Traits.Instances.Deadly.ID, "d6");
            builder.Add(Guid.Parse("e0a5c22e-7b7e-48b2-9491-327bb5e92a07"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("a405b197-9069-4ac3-9553-b8e5b8b19eb0"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("2df1096f-6185-4cce-8256-288d4bca5dd5"), Traits.Instances.Shove.ID);
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("894c792c-2467-4515-809a-8e3419fbc72a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 63
            };
        }
    }
}
