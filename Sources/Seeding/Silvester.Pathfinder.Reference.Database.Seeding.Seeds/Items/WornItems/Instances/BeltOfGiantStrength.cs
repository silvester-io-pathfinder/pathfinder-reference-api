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
    public class BeltOfGiantStrength : Template
    {
        public static readonly Guid ID = Guid.Parse("6f1527f0-21a5-4564-8986-6fdd8fd97466");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Belt of Giant Strength",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("629853e9-14b3-44d5-8415-07281ecd0a07"), "This thick leather belt is decorated with a buckle carved from glittering quartz in the shape of a fist. You gain a +3 item bonus to Athletics checks and a +2 circumstance bonus to Athletics checks to lift a heavy object, Escape, and Force Open. When you invest the belt, you either increase your Strength score by 2 or increase it to 18, whichever would give you a higher score.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("64776800-861f-4a05-b942-5884ff6440d7"), Traits.Instances.Apex.ID);
            builder.Add(Guid.Parse("ff05f2d7-19f4-4fc2-9671-9c961a6184ad"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("eeaa011e-b9e5-48ac-8e46-47eca781244c"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("cf8b5d9b-0b8c-416e-8785-d641ebbe4459"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("2b974839-fcbb-4111-9b05-adcced975338"),
				Name = "Belt of Giant Strength",
				Usage = "Worn belt.",
				Level = 17,
				Price = 1500000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6df84c5c-4968-4475-a270-f560cf76124d"), ActionTypes.Instances.Reaction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Trigger("You are targeted by a thrown rock attack, or a rock would fall on you.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("f40df1be-d59f-4030-9971-ef34da4dce0c"), "Attempt an Athletics check to grab the triggering rock. Use the Athletics DC of the creature throwing the rock, the DC of the hazard or other effect, or DC 35 if no other DC is applicable. You must have a free hand to catch the rock, but you can Release anything you're holding in a hand as part of this reaction.");
                            })
                            .RollableEffect(Guid.Parse("d8b59efd-9f30-4cd4-b5d6-807d28c1a939"), effect =>
                            {
                                effect
                                    .Success("You safely catch the rock, take no damage, and are now holding the rock.")
                                    .Failure("You take half damage.")
                                    .CriticalFailure("You take full damage.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c4a3f22-4e8f-4c84-9355-9fcdcb34f6dc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 603
            };
        }
    }
}
