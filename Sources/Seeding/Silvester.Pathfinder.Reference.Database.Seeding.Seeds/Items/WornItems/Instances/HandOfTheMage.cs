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
    public class HandOfTheMage : Template
    {
        public static readonly Guid ID = Guid.Parse("e8a68345-eac8-496b-b9cb-73cbfc813f3c");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Hand of the Mage",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5d17a80e-6987-436b-919f-ba246d263f2b"), "This mummified elf hand hangs on a golden chain, its gnarled fingers locked in a peculiar pattern.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d686cbb1-2209-4083-a874-39a78412dbc1"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("b79f7a65-cdfa-4abb-a9e8-cf5bd31c09c7"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("8829519a-6c6f-42e9-b024-fb2aea8bd62c"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("e068d816-3d24-4155-94ba-cbfe2efb4e49"),
				Name = "Hand of the Mage",
                Usage = "Worn.",
				Level = 2,
				Price = 3000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("065bd8e3-9820-4962-961f-44b36a6e1318"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("a665ee6a-67d9-47e0-9960-feb8e11ab9b6"), "You cast Mage Hand.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da9949a9-f3c4-4b2c-8c72-de0f24fdbd9a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 611
            };
        }
    }
}
