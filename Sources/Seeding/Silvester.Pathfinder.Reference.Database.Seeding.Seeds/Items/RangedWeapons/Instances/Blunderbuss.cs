using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class Blunderbuss : Template
    {
        public static readonly Guid ID = Guid.Parse("c0af0df1-3560-46d7-b10a-d5c1263920d7");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Blunderbuss",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1d366054-8ccf-4b6e-9f6f-991fcfc70d78"), "This weapon fires pellets from a trumpet-shaped barrel, making it an excellent choice for hunting brush fowl or dealing damage within a short, broad area. Adventuring gunslingers often carry a blunderbuss to deal with swarms of vermin and similar threats.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("459ed48f-672e-47a8-b757-42280e9b199e"),
				Name = "Blunderbuss",
				Hands = "2",
				Price = 800,
				Reload = 1,
				Range = 40,
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("72f87770-fc95-494b-9942-393f75fb5a1e"), Traits.Instances.Concealable.ID);
            builder.Add(Guid.Parse("fcc8ab10-3615-4fda-80d2-0ede600e0128"), Traits.Instances.Scatter.ID, "10 ft.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95529c42-6877-4468-b83f-e0478868677d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page =  151
            };
        }
    }
}
