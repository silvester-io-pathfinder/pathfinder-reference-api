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
    public class RingOfLies : Template
    {
        public static readonly Guid ID = Guid.Parse("bf1c79fd-8fad-4cf7-b8f3-c159c4ed780d");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Ring of Lies",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b070eda3-35c2-46b5-91ab-e05614f8ca71"), "This plain silver ring has an almost oily sheen. While wearing the ring, you gain a + 2 item bonus to Deception checks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8176b13c-8cc3-4ec8-ab38-c75de4850fff"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("8fe2e6b1-e6a0-4bea-b979-8d776db5b0ca"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("d6bb817d-1195-49ec-af95-f98e9977aacc"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("a4781f46-fddd-48c8-a99c-bdd884c7b0b3"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("1d786118-0fbf-42dc-8336-a7c2b3faccd5"),
				Name = "Ring of Lies",
                Usage = "Worn.",
				Level = 10,
				Price = 85000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5c52502a-075c-44d1-96f8-4b0fd6bc95b8"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("28c8b0f5-775a-4349-b4a5-3c25f1ba5e16"), "Snapping your fingers on the hand that wears the ring causes the ring to cast Glibness on you with no visual manifestations of a spell being cast.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("469ba631-e98a-4888-a310-2120e1c9273f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 614
            };
        }
    }
}
