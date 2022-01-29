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
    public class BootsOfSpeed : Template
    {
        public static readonly Guid ID = Guid.Parse("94e7da52-19a2-4e66-9fa8-19943716c583");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Boots of Speed",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fd45dc37-7650-4026-bbdf-66959f0f2712"), "These sleek red boots make your legs feel like they're bursting with energy. You gain a +5-foot item bonus to your land Speed and to any climb or swim Speeds you have.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("19dd0b28-07d7-42b8-a88c-3d22755a43af"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("250fda82-ce7a-4bfd-93ff-fb5f7130644c"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("058b1d0e-4521-4163-ad0d-7f493f3fbd0c"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("c65fb431-41b3-4da4-afb3-286f2293179d"),
				Name = "Boots of Speed",
                Usage = "Worn shoes.",
				Level = 13,
				Price = 300000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("fe348e43-6b49-457c-8363-86d980e6a899"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("2a15abbe-1abe-497f-bc27-fe6a60b49d47"), "You click the heels of the boots together and gain the quickened condition for 1 minute. You can use the extra action to Stride, Climb, or Swim. (You must still attempt an Athletics check for the Climb and Swim actions unless you have the appropriate movement type.)");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3261054-3e2d-49b2-874b-68d1fd39445b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 606
            };
        }
    }
}
