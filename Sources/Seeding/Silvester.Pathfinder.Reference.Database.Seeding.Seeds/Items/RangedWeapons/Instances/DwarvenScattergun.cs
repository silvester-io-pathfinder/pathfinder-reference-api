using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class DwarvenScattergun : Template
    {
        public static readonly Guid ID = Guid.Parse("c98d99b8-dcf2-4fa4-8ce1-64cd36a3e6f2");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Dwarven Scattergun",
                WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("cfcbd616-5ac0-410b-8ca0-daf23f8c892e"), "A favored weapon of dwarf scouts from Dongun Hold, the dwarven scattergun is a powerful weapon designed to take advantage of a dwarf�s sturdy frame. A dwarven scattergun fires a large paper cartridge stuffed with black powder and knuckle-sized lumps of metal, creating a devastating burst so destructive that a foolish dwarf might find themself catching painful ricochets when firing at a too-close target. Some scatterguns are crafted with a clockwork firing tray that can quickly sort and load black powder and shot without needing a prepackaged cartridge, though this is largely an aesthetic feature with no real mechanical benefit.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("c6ee4bfc-00a7-4d2e-83ff-7d124d0a8e68"),
				Name = "Dwarven Scattergun",
				Hands = "2",
				Price = 1000,
				Reload = 1,
				Range = 50,
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("21e43aaf-0bcb-430b-810a-637b3b9c992b"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("a447ecc7-f3db-4414-8e6c-e4ff44627b9a"), Traits.Instances.Dwarf.ID);
            builder.Add(Guid.Parse("59d9d18e-bb4c-45a7-bf22-611b99a13219"), Traits.Instances.Kickback.ID);
            builder.Add(Guid.Parse("13f6fb96-5e54-408c-ab16-4ce23fb8d368"), Traits.Instances.Scatter.ID, "10 ft.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a23afc3-ae4e-4559-85f7-283900bd3459"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
