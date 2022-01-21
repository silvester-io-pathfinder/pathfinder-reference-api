using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class Bola : Template
    {
        public static readonly Guid ID = Guid.Parse("827647a5-7143-4b19-bfee-a974d3636d96");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Bola",
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Sling.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a53f658a-f077-4dbc-8dd5-a2d9c8627d8d"), "This throwing weapon consists of weights tied to the end of long cords, which can be used to bludgeon foes or entangle their legs.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("0876be26-28fb-4829-9b06-675dfe04debe"),
				Name = "Bola",
				Hands = "1",
				Price = 50,
				Range = 20,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				RarityId = Rarities.Instances.Common.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("14bde3ff-4e65-4078-bf42-a3a4d6ee93ee"), Traits.Instances.Nonlethal.ID);
            builder.Add(Guid.Parse("f0b92fc6-27ea-47f1-93fd-31270d06ef0d"), Traits.Instances.RangedTrip.ID);
            builder.Add(Guid.Parse("5e719067-d3ae-414d-b6e9-3b9784c44add"), Traits.Instances.Thrown.ID, "20 ft.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff4711ed-2ae0-4ec0-bdab-8bbcfb2e2074"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 248
            };
        }
    }
}
