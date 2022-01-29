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
    public class ChimeOfOpening : Template
    {
        public static readonly Guid ID = Guid.Parse("5a023f68-3eed-45e1-8330-3a0435c8df30");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Chime of Opening",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3bd66000-2d5d-4c14-bc28-8423ee4fdb08"), "This hollow mithral tube is about a foot long and bears engravings reminiscent of open locks and broken chains. The chime can be activated 10 times before it cracks and becomes useless.");
        }

       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("252450e5-3935-4e5b-9aa9-82fdb4464f8e"),
                Name = "Chime of Opening",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 6,
                Price = 23500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ea074bf0-d155-45eb-bbd3-e2950ed303c0"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("e5550513-0f2b-4bc6-a99a-e2a07d51299c"), "You aim the chime at a container, door, or lock you want to open and strike the chime. The chime sends out magical vibrations that attempt a Thievery check against the lock's DC, with a Thievery bonus of +13. This targets only one lock or binding at a time, so you might need to activate the chime multiple times to open a target with several forms of protection.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ea3d495d-1e7d-453d-aa60-9b46f12a5209"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("abaa0b8f-1bcb-470b-822c-f64ec6b7a484"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2497cc1f-c197-4bdb-8d9e-c3da56657e92"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 572
            };
        }
    }
}
