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
    public class SlippersOfSpiderClimbing : Template
    {
        public static readonly Guid ID = Guid.Parse("8a68bb70-530d-429a-ad1f-634f44136f6a");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Slippers of Spider Climbing",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("77fe4941-291f-4d79-94f3-37d253935d62"), "These soft slippers are made of fine gray silk. If the slippers are left unattended for a while, they tend to attract spiders that nest inside.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5f1a2e9a-486e-42eb-a8b8-8fed288488d4"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("856002c9-1f3c-471c-b19c-630b49c56d2e"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("ba1c0bf9-1d32-4906-ab96-1e5de3c97b16"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("8bcbfa75-c8e6-4bd5-ac4e-1f1af3c28e6a"),
				Name = "Slippers of Spider Climbing",
                Usage = "Worn shoes.",
				Level = 7,
				Price = 32500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a4ad9112-be86-43af-b01a-e35b290362fb"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per hour.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("d6cbb71d-e05b-4cc0-8983-563233225e75"), "Tiny, hairlike tendrils extend from the slippers' soles, allowing you to walk on vertical surfaces or even to move upside down along ceilings. For 1 minute, you gain a 20-foot climb Speed and you don't need to use your hands to Climb. However, the slippers require decent traction for you to walk on a wall, so they provide no benefit when you're moving across greased, icy, or oiled surfaces.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c798d87c-010a-4938-a21e-a3bbeb651181"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 616
            };
        }
    }
}
