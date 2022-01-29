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
    public class LiftingBelt : Template
    {
        public static readonly Guid ID = Guid.Parse("3afcab27-02fd-4d9b-9988-61c6e6b3422c");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Lifting Belt",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("25d8d969-2c53-4eab-a55b-54b366f776c2"), "This wide leather belt grants you a +1 item bonus to Athletics checks and increases the amount you can easily carry. You can carry Bulk equal to 6 + your Strength modifier before becoming encumbered, and you can hold and carry a total Bulk up to 11 + your Strength modifier.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4691757c-196b-4e53-b40b-c118fe10dd02"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("49a01cda-fd76-417a-8492-b5cc6896035d"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("a187b75c-54e1-40a4-913c-6540261efc86"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("8d860eff-352d-40b4-bc26-e384360398f6"),
				Name = "Lifting Belt",
                Usage = "Worn belt.",
				Level = 4,
				Price = 8000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("43de9f56-8dec-41dc-9939-f32202b9e722"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("279a6b35-0a00-4621-a122-6610a95098c5"), "You lift an object of up to 8 Bulk as though it were weightless. This requires two hands, and if the object is locked or otherwise held in place, you can attempt to Force it Open using Athletics as part of this activation. The object still has its full weight and Bulk for all other purposes - you just ignore that weight. The effect lasts until the end of your next turn.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd91fb42-b4ae-4be0-8861-8eac266ab407"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 613
            };
        }
    }
}
