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
    public class Wayfinder : Template
    {
        public static readonly Guid ID = Guid.Parse("f025ba04-543e-4e74-9172-6823ae71ca20");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Wayfinder",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f7631c00-423b-4c8c-9832-b11dff510499"), "This compact compass repurposes ancient technology to draw fantastic powers from the mysterious magical items called aeon stones. It serves as a badge of office for agents of the Pathfinder Society and as a status symbol among adventurers of any stripe. A wayfinder functions as a compass.");
            builder.Text(Guid.Parse("80edce17-828d-430a-884d-f175246ae903"), "An indentation in the middle of the wayfinder can hold a single aeon stone (page 604). Placing an aeon stone in this indentation provides you all the benefits of having the aeon stone orbiting your head, but it protects the stone from being noticed or stolen as easily. You invest a wayfinder and the aeon stone within it simultaneously, and they count as only one item toward your investiture limit. An invested aeon stone slotted in a wayfinder also grants its resonant power.");
            builder.Text(Guid.Parse("2047cccc-faff-4e59-9f7e-1711437e592e"), "If you have more than one wayfinder with an invested aeon stone on your person at a given time, destructive interference from their resonance prevents you from gaining benefits from any of them. You can still benefit from additional aeon stones orbiting your head, just not in wayfinders.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("241e87f8-0c6c-4e5e-80e7-ea505f2f8e03"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("be8d098f-31e2-4f21-a975-a74b6d24fa45"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("2afcae7d-8209-4c10-9b7c-b4a2698db9fd"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("7feb2bca-5efe-4396-b2c1-2bc3ad260bf3"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("e02eefd4-0e8f-4c29-8e32-f3a5c87993b7"),
				Name = "Wayfinder",
                Usage = "Worn.",
				Level = 2,
				Price = 2800,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("fb78300f-0a28-4742-9761-b1a6229de89a"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("998d0313-fdc7-4fd8-b4f4-f187ffa1ab06"), "The wayfinder is targeted by a 1st-level Light spell.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e5e4640-f017-4a65-82df-2359ecaf2d95"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 617
            };
        }
    }
}
