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
    public class CompositeShortbow : Template
    {
        public static readonly Guid ID = Guid.Parse("d093010f-0b1b-41d0-b76e-c5532a2d99a5");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Composite Shortbow",
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Bow.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d6e9cf35-a50a-49c6-b480-09e3dc883b36"), "This shortbow is made from horn, wood, and sinew laminated together to increase the power of its pull and the force of its projectile. Its compact size and power make it a favorite of mounted archers. Any time an ability is specifically restricted to a shortbow, it also applies to composite shortbows unless otherwise stated.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("34e2a2b9-8a3f-4e53-bbb8-0536d3be755a"),
				Name = "Composite Shortbow",
				Hands = "1+",
				Price = 1400,
				Reload = 0,
				Range = 60,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Common.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("844dcbc5-4e31-4447-876f-13a6f91e1447"), Traits.Instances.Deadly.ID, "d10");
            builder.Add(Guid.Parse("dccfefd2-7709-42df-958a-a155b3d0d302"), Traits.Instances.Propulsive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb97184c-4af3-4ac7-9bb4-3eb3d5999ab6"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
