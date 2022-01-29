using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Consumables.Instances
{
    public class DustOfDisappearance : Template
    {
        public static readonly Guid ID = Guid.Parse("4302d8f6-7e0e-4f92-94e2-7078cbd46989");

        protected override Consumable GetConsumable()
        {
            return new Consumable
            {
                Id = ID,
                Name = "Dust of Disappearance",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f33d61fa-1d2a-45a5-8a88-1f1cfa426c92"), "This powder shimmers like a thousand tiny motes of light. Activating the dust by sprinkling it on yourself or a creature within reach casts a 4th-level invisibility spell with a duration of 1 minute on that creature. This invisibility can't be negated or seen through by any spell of 3rd level or lower or any item of 5th level or lower.");
        }

        protected override IEnumerable<ConsumableVariant> GetConsumableVariants()
        {
            yield return new ConsumableVariant
            {
                Id = Guid.Parse("0b2c569a-c17c-4891-8d11-210657fd8f73"),
                Name = "Dust of Disappearance",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 9,
                Price = 13500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3a6dcf59-a841-4fae-be4f-9bf8c76a7a4d"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d2c894c0-929c-464a-b665-8c817d785b41"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e1f8376b-0238-4796-9e54-c4342f6da496"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("7ea35e39-5aad-4bb5-ad5d-e6a762edce55"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff7a3be6-3e07-4de5-b946-754f2c2cbc11"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 570
            };
        }
    }
}
