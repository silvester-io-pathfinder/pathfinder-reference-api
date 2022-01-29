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
    public class CollarOfEmpathy : Template
    {
        public static readonly Guid ID = Guid.Parse("8cbd277b-d232-4352-9c2d-042b5075c54c");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Collar of Empathy",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("19c1fe69-c21d-4b4c-b8ee-288376a89393"), "his ornate collar of intertwined leather strips of contrasting colors is paired with a bracelet of a similar construction. When you wear and invest the bracelet and your companion wears and invests the collar, you gain a stronger connection to each other. You and your companion can always sense each others' emotional states and basic physical wants and needs.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2fe1bfba-1d13-4738-a251-4147089d5f2e"), Traits.Instances.Companion.ID);
            builder.Add(Guid.Parse("23808cd4-0fb9-4cc4-8b40-d53d2bf1ff90"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("66ebeecd-bc50-452a-b8d7-c27a14018c97"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("0bd5fb61-1b15-4be3-ac77-83eca889eb50"), Traits.Instances.Primal.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("f4612cfc-d30f-4869-9de7-559c1273ace8"),
				Name = "Collar of Empathy",
                Usage = "Worn collar (companion) and worn bracelet (you).",
				Level = 9,
				Price = 60000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("94223d40-d0cf-4a8c-b948-b3e3e3de83d9"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("5f2a4b6f-8e8c-4c87-a064-3981d593f997"), "You perceive through your animal companion's senses instead of your own. You can Sustain the Activation. You are unaware of your own surroundings for as long as you are using your animal companion's senses. In addition to the obvious use when you are separated from your companion, this ability might allow you to notice sounds, scents, and other stimuli that your companion's senses register but yours alone don't.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbdf8540-cfa8-4284-99a1-4996e98ca5cc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 604
            };
        }
    }
}
