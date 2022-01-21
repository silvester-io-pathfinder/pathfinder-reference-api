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
    public class RingOfCounterspells : Template
    {
        public static readonly Guid ID = Guid.Parse("17d84247-63db-47d2-a84e-42f030c3d396");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Ring of Counterspells",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("710d885d-bd26-4a13-b8f7-7969d2c3492f"), "This ornate silver ring bears two competing geometric designs of brightly colored and wildly clashing inlaid gemstones. A spellcaster can cast a single spell into this ring as long as no spell is currently stored within, expending the normal time, costs, and so forth to Cast the Spell. The spell�s effect doesn�t occur; the spell�s power is instead stored within the ring.");
            builder.Text(Guid.Parse("cef88c34-fb04-4914-a080-0cb6ad6f9df5"), "When you invest a ring of counterspells, you immediately know the name and level of the spell stored inside, if any. A ring of counterspells found as treasure has a 50% chance of having a spell stored in it. The GM determines that spell.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("adf11186-182d-4f86-ac4f-571285c79d2a"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("775c5d06-a7c8-4017-ab24-a5b26beeab4e"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("d012e643-ed53-4f87-a256-e31c3c71db20"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("b5b7e075-b413-4224-9f62-5d65b4566f38"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("5c40bec8-0c6e-4289-b5bc-c766466a3e00"),
				Name = "Ring of Counterspells",
                Usage = "Worn.",
				Level = 10,
				Price = 92500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("330c1065-a6cc-457b-9cc0-e271916892a5"), ActionTypes.Instances.Reaction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You are targeted by or within the area of the spell stored within the ring.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("27787c7c-4c3f-4881-949c-787a2d469670"), "You can attempt to counteract the triggering spell, using the level of the spell stored in the ring and a counteract modifier of +19.");
                                builder.Text(Guid.Parse("2365912e-29eb-4733-9967-2510747cd158"), "Once you do, the stored spell�s energy is spent, and the ring is empty.");
                            });
                    })
                    .Add(Guid.Parse("04851757-eea3-431f-acba-068b3817ddb6"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("04584798-10a9-42ae-9f62-251af1ec1937"), "You harmlessly expend the stored spell, having no effect but emptying the ring so that another spell can be cast into it.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c955fed7-bd26-48a3-920f-8bd1b643568b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 614
            };
        }
    }
}
