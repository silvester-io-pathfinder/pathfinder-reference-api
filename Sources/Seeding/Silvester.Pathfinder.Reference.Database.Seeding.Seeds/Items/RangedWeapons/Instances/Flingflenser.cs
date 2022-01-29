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
    public class Flingflenser : Template
    {
        public static readonly Guid ID = Guid.Parse("dc38dbcb-386f-409a-8a38-c98c47650877");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Flingflenser",
                WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("dc27ed6e-6fb8-4f97-8b13-9a7f76d555f8"), "A flingflenser is a goblin-designed weapon ending in an ovoid tube with a hatch and handle on the narrow end. A cluster of circular blades held together and attached to a black powder packet with a thin leather strap serves as ammunition and is loaded through the hatch before being fired with a flintlock or other external ignition mechanism. The flingflenser's sturdy design also places it among the more reliable goblin weapons.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("6c474f3a-a7b9-470c-9e80-b4376c3cb16a"),
				Name = "Flingflenser",
				Hands = "2",
				Price = 600,
				Reload = 1,
				Range = 30,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("99fb0f1d-0040-401e-a5d8-5fdfa0a8d93f"), Traits.Instances.Backstabber.ID);
            builder.Add(Guid.Parse("18a46881-bb3d-40e3-9bca-fb9d244577d2"), Traits.Instances.Fatal.ID, "d10");
            builder.Add(Guid.Parse("41fd8990-e7e6-42c4-b494-98697202796c"), Traits.Instances.Goblin.ID);
            builder.Add(Guid.Parse("8ffffd35-3223-49a2-b7a1-fe4d04f408d0"), Traits.Instances.Scatter.ID, "5 ft."); 
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("306a8267-66e1-4d4c-b6fe-99a5b4a49783"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
