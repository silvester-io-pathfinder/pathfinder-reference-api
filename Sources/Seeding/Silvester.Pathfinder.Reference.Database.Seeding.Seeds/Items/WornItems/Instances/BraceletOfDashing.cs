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
    public class BraceletOfDashing : Template
    {
        public static readonly Guid ID = Guid.Parse("e2bb8ef3-83d7-4fd5-82d0-729f87254b5d");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Bracelet of Dashing",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("19774755-e03e-441c-af4d-48f5c38fa855"), "This jangling, silvery bracelet makes you lighter on your feet, giving you a +1 item bonus to Acrobatics checks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d3209e24-9858-4bf7-8a3f-4827112c712c"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("4de63012-790b-4065-8350-78c14a3b7b00"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("c78998af-c529-4776-a327-f250e66ea71d"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("035bd966-7c66-4a33-8dc5-d141744d91e9"),
				Name = "Bracelet of Dashing",
                Usage = "Worn.",
                CraftingRequirements = "",
				Level = 3,
				Price = 5800,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1e7a95d1-dadd-4bd9-8f26-28d9e3a48a77"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("61c6e28c-92c3-48ca-a4b0-eed389d75d0c"), "You gain a +10-foot status bonus to Speed for 1 minute.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("022db0bf-d00c-444e-8360-6bd444c297d0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 607
            };
        }
    }
}
