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
    public class BroomOfFlying : Template
    {
        public static readonly Guid ID = Guid.Parse("0d53db1d-d758-4ffc-a391-0ea807ca07a7");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Broom of Flying",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("adb1d725-ca4b-4bd0-8ac3-932eb6a237a7"), "This broom has a tenuous connection to gravity, and it tends to drift even while stowed. You can ride on the broom using one hand to guide it, and the broom can carry up to one passenger in addition to you. The broom moves at a fly Speed of 20 feet. The broom can carry only so much, taking a -10-foot penalty to its Speed if laden with more than 20 Bulk, and crashing to the ground if it carries more than 30 Bulk.");
        }

       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("117f6368-ca76-4af5-a4f4-77b3b23e3a56"),
                Name = "Broom of Flying",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 12,
                Price = 190000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("79e62a13-460a-4da1-9cad-4cfb2b203cbc"), ActionTypes.Instances.TwoActions.ID, "Activate", action => 
                    {
                        action
                            .Kind("Command, Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("957c53bb-8e56-4b54-9ebf-9d4f384ad1e1"), "You name a destination on the same plane, and the broom speeds toward it at a fly Speed of 40 feet. You must either clutch the broom with two hands in order to ride it, or you need to release the broom to send it off with no rider. If you don't have a good idea of the location, layout, and general direction of the destination, or if your named destination is on another plane, the broom wanders aimlessly, circling back to its starting location after 30 minutes.");
                                details.Text(Guid.Parse("db926070-da58-4e87-9395-5ac7e256af99"), "If the broom carries a rider, this activation lasts until 4 hours pass (typically 16 miles of travel), the broom reaches its destination, or you Dismiss the activation. If the broom doesn't have a rider, the activation lasts until the broom reaches its destination. When the activation ends, the broom floats to the ground and can't be activated again for 1 hour.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("84b1ef95-915d-4178-ad76-b679ef260139"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("20d8f763-a1bb-448f-8f1e-e7ab5b8ee913"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a68c1a0e-ed59-473a-92d5-6e48af17efa3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 572
            };
        }
    }
}
