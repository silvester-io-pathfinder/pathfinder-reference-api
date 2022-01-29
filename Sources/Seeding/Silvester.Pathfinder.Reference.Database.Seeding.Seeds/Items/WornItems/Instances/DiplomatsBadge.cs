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
    public class DiplomatsBadge : Template
    {
        public static readonly Guid ID = Guid.Parse("f8472147-6902-463f-8461-f1a48fe3f63d");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Diplomat's Badge",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a9b67d10-eec4-4830-8fe5-e63c0980cfe9"), "When displayed prominently, this brass badge makes creatures find you more agreeable. You gain a +1 item bonus to Diplomacy checks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4f26b231-deb3-4c1b-97d1-a38604d9a237"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("c5125ae1-fd5a-443b-9f6a-07fc29b2ff31"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("a79b76c2-9364-455c-bb0b-cb783e511614"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("92c4fb0b-4d00-4e0f-b5d9-0f9f9f42ee21"),
				Name = "Diplomat's Badge",
                Usage = "Worn.",
                CraftingRequirements = "",
				Level = 5,
				Price = 12500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9ca1bb8e-e535-4ab3-850c-cd6042cb13a1"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Recall Knowledge")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("99bedce5-2935-4cdb-b51e-2fbd40a34830"), "Attempt a DC 20 check to Recall Knowledge about people of a human ethnicity, a non-human ancestry, or some other type of creature. (The GM determines what your options are.) If you succeed, the badge's bonus increases to +2 for Diplomacy checks with creatures of that group for the rest of the day.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42c7ace5-5404-4451-99d7-36a816a0d2d5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 609
            };
        }
    }
}
