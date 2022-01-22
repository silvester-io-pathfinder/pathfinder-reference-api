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
    public class BagOfHolding : Template
    {
        public static readonly Guid ID = Guid.Parse("3dff2a48-b7eb-4b3c-873a-88b24ad7a49d");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Bag of Holding",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("05233ff7-a1e7-4f86-95b1-c530f2789127"), "Though it appears to be a cloth sack decorated with panels of richly colored silk or stylish embroidery, a bag of holding opens into an extradimensional space larger than its outside dimensions. The Bulk held inside the bag doesn�t change the Bulk of the bag of holding itself. The amount of Bulk the bag�s extradimensional space can hold depends on its type.");
            builder.Text(Guid.Parse("ca86c6e1-f087-4646-a9d0-6990d768cb34"), "You can Interact with the bag of holding to stow items in it or remove them just like a mundane sack. Though the bag can hold a great amount of material, an object still needs to be able to fit through the opening of the sack to be stored inside.");
            builder.Text(Guid.Parse("7952841d-93fb-42fb-a3ea-51427e85dfbd"), "If the bag is overloaded or broken, it ruptures and is ruined, causing the items inside to be lost forever. If it�s turned inside out, the items inside spill out unharmed, but the bag must be put right before it can be used again. A living creature placed inside the bag has enough air for 10 minutes before it begins to suffocate, and it can attempt to Escape against a DC of 13. An item inside the bag provides no benefits unless it�s retrieved first. An item in the bag can�t be detected by magic that detects only things on the same plane.");
        }


        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("7ddb4694-2204-41a7-b91f-65430a78c57c"),
                Name = "Bag of Holding (Type I)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 4,
                Price = 7500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("00689c5e-6ae7-4c60-a000-6f2d64f62a08"), "25 Bulk Capacity.")
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("7d72716e-d073-44c9-ba82-5e2c1e381a49"),
                Name = "Bag of Holding (Type II)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 7,
                Price = 30000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("70951ac8-2ebb-4ef8-ba5b-7073feead27b"), "50 Bulk Capacity.")
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("490e8f7b-80c6-415c-a340-5cc56cc19791"),
                Name = "Bag of Holding (Type III)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 11,
                Price = 120000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6b893618-0092-4f56-b141-406918ac3958"), "100 Bulk Capacity.")
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("5d7532d5-a07c-4346-9eb0-208d84b7b94c"),
                Name = "Bag of Holding (Type IV)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 13,
                Price = 240000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("374159f1-b8f6-44da-9b5b-b159240b57c8"), "150 Bulk Capacity.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7574fa42-4fad-49fe-aa97-aeda75e2a0f3"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("c3d7171b-6887-487c-8050-92117e5b9231"), Traits.Instances.Extradimensional.ID);
            builder.Add(Guid.Parse("aa551917-3171-418c-ab3e-552959d6d5c7"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4af1e240-7a43-4219-aabd-2cebda06e1c9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 572
            };
        }
    }
}
