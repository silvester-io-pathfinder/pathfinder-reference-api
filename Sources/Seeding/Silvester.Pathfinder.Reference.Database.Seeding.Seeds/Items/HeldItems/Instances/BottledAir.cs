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


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.HeldItems.Instances
{
    public class BottledAir : Template
    {
        public static readonly Guid ID = Guid.Parse("3ce42871-9c49-4f95-9dea-3ea4f3675ea1");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Bottled Air",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("12243079-89b3-47fc-b10e-d20494f1edf5"), "Appearing to be an ordinary corked glass bottle, this item contains a limitless supply of fresh air. You must uncork the bottle with an Interact action before you can activate it.");
        }

       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("cacb61ef-f509-4eaa-871e-57ce8ec6aaf8"),
                Name = "Bottled Air",
                Usage = "Held in 1 hand",
                Hands = "2",
                Level = 7,
                Price = 32000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("05dfe985-f21c-41e4-a684-c795a60e1ab0"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("ada52702-4b21-4f95-a428-bd422f030dac"), "You draw a breath of air from the bottle. This allows you to breathe even in an airless or toxic environment. Air doesn't escape the mouth of the bottle, so leaving the open bottle in an airless environment doesn't change the environment.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("09731f1a-c298-420f-8c63-3498b51a81b0"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("6a23c20f-647e-4901-a581-ce7a549444c4"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("5109b739-84f9-4221-8561-743429106fc3"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("584467d5-b2b5-4494-9b1d-9431db288961"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 572
            };
        }
    }
}
