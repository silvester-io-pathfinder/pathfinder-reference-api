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
    public class HeadbandOfInspiredWisdom : Template
    {
        public static readonly Guid ID = Guid.Parse("2f545401-2316-4c69-a235-592fc89d9da6");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Headband of Inspired Wisdom",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c1338397-b172-4e59-ba25-2e23e15366b0"), "This simple cloth headband remains pristine and clean at all times, no matter the circumstances. When you invest the headband, you either increase your Wisdom score by 2 or increase it to 18, whichever would give you a higher score.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4aefa14c-22f6-41ba-900c-277a559f0dd7"), Traits.Instances.Abberration.ID);
            builder.Add(Guid.Parse("5422dc53-b3d1-4a77-b6e5-4081995be3ff"), Traits.Instances.Apex.ID);
            builder.Add(Guid.Parse("f8bffd64-c88a-44b9-966f-00bea2b662ff"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("83534559-4583-4b8e-b0c4-d4d44017ad35"), Traits.Instances.Magical.ID);
        }
        
        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("8a35be6b-8724-46a1-97c2-40af65d63a44"),
				Name = "Headband of Inspired Wisdom",
                Usage = "Worn cirklet.",
				Level = 17,
				Price = 1500000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b9740fc1-4807-4cec-b856-5a30802b6cb2"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("32b35036-d05c-4764-9f9d-be02e934ca00"), "When you are considering a course of action, you get a gut feeling about whether it�s a good idea. You gain the effects of an augury spell, except that you receive the result from your own instincts rather than an external source.");
                            });
                    })
                    .Add(Guid.Parse("f6a2cb93-5515-4e79-ac97-04753814c9d9"), ActionTypes.Instances.Reaction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You fail a saving throw against an effect that makes you confused, fascinated, or stupefied.")
                            .Frequency("Once per hour.")
                            .Traits(builder =>
                            {
                                builder.Add(Guid.Parse("02b36ee4-be91-4bee-8511-f0e4bbafacd7"), Traits.Instances.Fortune.ID);
                            })
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("8a0d82c9-d4ed-4281-9060-7edf1d260233"), "The headband of inspired wisdom clears your mind. You can reroll the saving throw and use the better result.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e57b073-1db5-4f75-9137-5de859e6e1e0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 604
            };
        }
    }
}
