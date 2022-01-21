using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class CollarOfInconspicuousness : Template
    {
        public static readonly Guid ID = Guid.Parse("97e64da9-7853-4c2e-a9ad-3610add9a983");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Collar of Inconspicuousness",
              
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0f767dc3-43d7-4ce6-8b1e-00881235ed6a"), "This leather collar�s worn and almost threadbare look belies its magical nature. When your companion wears and invests the collar, it gains the ability to change its appearance from that of a ferocious animal into a more inconspicuous form.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a153048e-fbc4-4c98-88bf-f8dfd9958afa"), Traits.Instances.Companion.ID);
            builder.Add(Guid.Parse("6468f4b1-831b-4b7b-9ed9-275fcc211923"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("88a9c2b6-5554-4610-af16-974735075bcb"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("db33c82b-4ccf-4454-bb1e-f3bf9bdea49f"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("f9741a26-a69b-47b9-a391-0c2d165429ff"),
				Name = "Collar of Inconspicuousness",
                CraftingRequirements = "",
				Level = 8,
				Price = 47500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c6eb0bb9-9c9b-450e-80c2-3bff4e288cdb"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("fd002091-1c63-4092-b5fa-85923c92ba32"), "You touch your animal companion to transform it into a nonthreatening Tiny creature of the same family or a similar creature (for instance, a house cat instead of a tiger, or a puppy instead of a wolf). This has the effects of pest form (2nd level, or 4th level if your companion can fly). The effect lasts until you Dismiss it.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93fe92e0-28dd-4bf6-a920-2495dbffd61d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 604
            };
        }
    }
}
