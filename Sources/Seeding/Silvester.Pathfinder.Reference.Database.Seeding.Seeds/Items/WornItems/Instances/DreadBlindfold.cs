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
    public class DreadBlindfold : Template
    {
        public static readonly Guid ID = Guid.Parse("d28667f6-d182-4d00-b37a-cb8aba5c4f27");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Dread Blindfold",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("75c730be-5023-43fc-a8bb-29f0d6d3dde7"), "When tied over your eyes, this ragged strip of black linen gives you a +3 item bonus to Intimidation checks and darkvision. You can see through the blindfold, but only using darkvision.");
            builder.Text(Guid.Parse("701bfe05-d96f-4f86-8521-18109b6a0067"), "The first time a particular creature sees you in a day, it must succeed at a DC 37 Will save or be frightened 1. This is an emotion, fear, and mental effect, and your allies become immune to it after about a week.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("cc8010af-ff69-4025-bcce-bdeee2ea9d70"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("755cdb4e-7fc7-443b-b5a3-ba395d837766"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("3d7547cf-f310-4754-aedc-c845a47bd070"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("206bc5e0-c2d0-42e4-ab3c-48613d6d4cc5"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("01885fef-9c7b-4829-9c5f-02aee823e596"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("35be5add-2fbb-44b0-89c1-40fcc0fd7c17"), Traits.Instances.Mental.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("032ed59d-7462-40a5-a858-edc15561d276"),
				Name = "Dread Blindfold",
                Usage = "Worn eyepiece.",
				Level = 17,
				Price = 1500000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6bafd483-6ab3-44d8-842a-6aee0c7abbbe"), ActionTypes.Instances.FreeAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Trigger("You damage a creature with a Strike.")
                            .Frequency("Once per minute.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("6971285a-1f10-4a3e-a19d-7ef7532bab4a"), "Your target is gripped by intense fear. This has the effect of a DC 37 phantasmal killer spell, but it is an enchantment instead of an illusion. The creature is then temporarily immune for 24 hours.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ac5137b-ecd1-4067-b9d0-d7882115fef3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 610
            };
        }
    }
}
