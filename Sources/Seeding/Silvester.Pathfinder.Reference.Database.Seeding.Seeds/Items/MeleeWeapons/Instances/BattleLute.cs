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
    public class BattleLute : Template
    {
        public static readonly Guid ID = Guid.Parse("08a0cd4f-fb35-497e-99ac-3949d11350e5");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Battle Lute",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("5d310465-2bae-4158-9f14-461ebef5e1cf"),
				Name = "Battle Lute",
				Price = 1500,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("8b0e7798-0976-46f2-bd24-8fd6331ee59e"), "This reinforced lute is suitable both for use as a handheld musical instrument and for bashing heads should a crowd turn sour. Its strings are finely braided wires that run along its sturdy metal neck.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("cf42d516-68e1-4c66-9629-7cac27c117d6"), Traits.Instances.Shove.ID);
            builder.Add(Guid.Parse("f8499375-240d-49e4-8a15-c4a24a87557c"), Traits.Instances.TwoHand.ID);
            builder.Add(Guid.Parse("2c341e41-16a1-4e5a-b1a6-140f78f83cea"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4249a8a4-14e5-43e3-9d55-61065c75422b"),
                SourceId = Pathfinder164.ID,
                Page = 73
            };
        }
    }
}
