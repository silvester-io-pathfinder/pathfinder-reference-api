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
    public class TravelersAnyTool : Template
    {
        public static readonly Guid ID = Guid.Parse("5a1bc0d8-cdec-405a-b9d9-251aa998951d");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Traveler's Any-Tool",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d7dcfddd-6c44-45f7-90b9-dd0713530590"), "Before it's activated, this item appears to be an ash rod capped with steel on either end.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("79c9826b-f763-4325-b9b9-d842ac6300e8"),
                Name = "Traveler's Any-Tool",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 6,
                Price = 20000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("7c46142e-5581-4497-ac94-0e44f2902aed"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Envision, Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("4a1cd224-ef8c-482b-91b8-2f9350e9bc43"), "You imagine a specific simple tool, and the any-tool transforms into it. (Usually, you can choose from a tool listed in Chapter 6). This transforms the wooden portion into any haft and the metal caps into spades, hammer heads, or the like, allowing for most basic tools but nothing more complex. You can return the item to its rod form with an Interact action.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("becfb049-bda3-41c0-9481-7a22472e6ff7"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("0d5c443b-b1f7-46f4-a123-cfe904faeafc"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64e59793-2314-48a9-bb7c-890c333b8f86"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 576
            };
        }
    }
}
