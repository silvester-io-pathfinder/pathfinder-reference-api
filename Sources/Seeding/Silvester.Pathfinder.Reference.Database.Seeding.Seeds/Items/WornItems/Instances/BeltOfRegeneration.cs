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
    public class BeltOfRegeneration : Template
    {
        public static readonly Guid ID = Guid.Parse("4cb48102-42eb-4115-b9af-8d3b2f870623");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Belt of Regeneration",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("de790f1e-9916-426b-9a7f-150f3b9218cb"), "This belt is crafted from rubbery troll hide that's green and orange in color. You gain 15 temporary Hit Points the first time you invest the belt in a day. When you invest the belt, you either increase your Constitution score by 2 or increase it to 18, whichever would give you a higher score.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e45dbc2d-8929-4058-b8a4-64d79c593d66"), Traits.Instances.Apex.ID);
            builder.Add(Guid.Parse("d3e275e5-200a-4568-bc68-3408bc01a5f5"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("31f5e7c0-07ec-4c65-bb17-503e73b8c698"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("e61d2867-0fdf-4846-905e-fbda15448abb"), Traits.Instances.Necromancy.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("f55241bb-5c2d-45a1-ba14-e067ef39caf1"),
				Name = "Belt of Regeneration",
				Usage = "Worn belt.",
				Level = 17,
				Price = 1500000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f38ca60c-3a26-4993-a976-721fe8e6ae22"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("87e3ec47-7985-4450-bc23-f0d20f61ee72"), "You tighten the belt one notch to gain a regeneration effect. For 2d4 rounds, at the start of your turn each round, you recover 15 Hit Points unless you took acid or fire damage since the start of your previous turn.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6cdf260a-c138-45d4-b9ac-285ed1fc59bd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 603
            };
        }
    }
}
