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
    public class DiademOfIntellect : Template
    {
        public static readonly Guid ID = Guid.Parse("55e66630-8bc2-4118-b860-6e1f8ffaeedc");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Diadem of Intellect",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b5263e07-76ff-4b9b-903f-261f98a8d440"), "An elegant, colorful gem cut into a complex geometric pattern is slotted into a narrow metal band that fits around your brow. You gain a +3 item bonus to checks to Recall Knowledge, regardless of the skill. When you invest the diadem, you either increase your Intelligence score by 2 or increase it to 18, whichever would give you a higher score. This gives you additional trained skills and languages, as normal for increasing your Intelligence score. You must select skills and languages the first time you invest the item, and whenever you invest the same diadem of intellect, you get the same skills and languages you chose the first time.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a12f8437-5c0c-4834-8ddb-13948d301ab5"), Traits.Instances.Apex.ID);
            builder.Add(Guid.Parse("a8af438c-e2c6-4c0f-9c9f-0272ee9d8c76"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("38622c99-58b6-4c92-b25f-c7206c8ceafe"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("d92f49fe-db61-45df-a45c-f56bcbf200f9"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("5a7c4bbf-6cc7-45da-9604-6b01424d8bad"),
				Name = "Diadem of Intellect",
                Usage = "Worn circlet.",
				Level = 17,
				Price = 1500000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                        .Add(Guid.Parse("321a2fee-5ebb-44a5-8858-17d64491855a"), ActionTypes.Instances.OneAction.ID, name: "Envision", action =>
                        {
                            action
                                .Kind("Envision")
                                .Frequency("Once per hour.")
                                .Details(builder =>
                                {
                                    builder.Text(Guid.Parse("8cc449ac-8d44-4b6f-8c6c-24a5e361ac48"), "You gain the effects of hypercognition.");
                                });
                        })
                        .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58490c28-c092-4c5b-ac73-25e3c2dc54d8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 603 
            };
        }
    }
}
