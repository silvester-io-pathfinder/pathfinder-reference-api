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
    public class PossibilityTome : Template
    {
        public static readonly Guid ID = Guid.Parse("05b76ec2-26c4-4f23-9f49-de3e301468b7");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Possibility Tome",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e4b05f12-0482-455b-a3b7-38df9d6d5aa6"), "An array of semiprecious stones is set into the ornate silver and beaten copper cover of this thick and weighty tome. If you open the book before it's been activated, its vellum pages are blank and pristine, but once activated, words dance and swim onto the pages before your eyes.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("00953958-b5cb-4df2-adcc-ee0930686597"),
                Name = "Possibility Tome",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 18,
                Price = 2200000,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c32879e7-c42c-4e6b-bd68-cf041df52eb6"), ActionTypes.Instances.LongAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Envision, Interact (10 Minutes)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("277eacfb-a5a2-4e1b-8bcb-45d57c973c80"), "As you flip through the book, you think about a broad topic you want to know more about. Choose one skill: Arcana, Crafting, Medicine, Nature, Occultism, Religion, Society, or a single subcategory of Lore. The book's pages fill with information about that skill, though only you can see the information. While the pages are full, you can spend an Interact action perusing the book just before attempting a check to Recall Knowledge with the chosen skill. This grants you a +3 item bonus to the check, and if you roll a critical failure, you get a failure instead. The information within the book disappears after 24 hours or when the tome is activated again.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0a73333d-6838-424f-9d27-d2f31a9e2a14"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("09affa04-8417-44f3-ab5c-bf45f9781f4c"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20b26308-e091-45ba-b810-6bc9799204db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 574
            };
        }
    }
}
