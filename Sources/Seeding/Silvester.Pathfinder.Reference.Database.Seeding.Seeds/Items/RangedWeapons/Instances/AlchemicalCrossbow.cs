using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class AlchemicalCrossbow : Template
    {
        public static readonly Guid ID = Guid.Parse("fc7b92de-da67-4924-8ee2-b07bfbec720d");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Alchemical Crossbow",
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = Bow.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ccf84f49-b96e-421c-9c57-cba8f97728d8"), "This crossbow can deliver alchemically infused bolts. The strange weapon has a metal bracket mounted on the side of the stock near the lath. As an action, you can load a single lesser alchemical bomb into the bracket; this bomb must be one that deals energy damage (such as an acid flask, alchemist's fire, bottled lightning, frost vial, or thunderstone). The next three attacks made with the crossbow deal 1d6 damage of the bomb's damage type in addition to the crossbow's normal damage. If the second and third attacks are not all made within 1 minute of the first attack, the bomb's energy is wasted. These attacks never deal splash damage or other special effects of the bomb and are not modified by any abilities that add to or modify a bomb's effect. The addition of the bracket serves to unbalance the weapon, reducing its range to 30 feet. It otherwise functions as a crossbow (when determining damage, reload, and so on). Creatures use their crossbow proficiency when using the alchemical crossbow. The alchemical crossbow costs 25 gp.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("ebcd3c1f-8d4e-43aa-b4d1-ac8b385aa858"),
				Name = "Alchemical Crossbow",
				Hands = "2",
				Price = 2500,
				Reload = 1,
				Range = 30,
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7af1b2c3-285f-4418-92a5-8b0c106c816d"), Traits.Instances.Alchemical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("538738b0-b51d-4e95-9468-2954f72fedba"),
                SourceId = TheFallOfPlaguestone.ID,
                Page = 56
            };
        }
    }
}
