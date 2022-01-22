using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Oils.Instances
{
    public class OilOfWeightlessness : Template
    {
        public static readonly Guid ID = Guid.Parse("a9158faa-b64a-44f5-ba69-af33af0d64c9");

        protected override Oil GetOil()
        {
            return new Oil
            {
                Id = ID,
                Name = "Oil of Weightlessness",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8404b1ba-dacd-423e-83f0-ef64dd813ff3"), "A shimmering oil that can be spread on an item to reduce it's weight.");
        }

        protected override IEnumerable<OilVariant> GetOilVariants()
        {
            yield return new OilVariant
            {
                Id = Guid.Parse("4fd8f641-63df-43af-8617-57a71251229a"),
                Name = "Oil of Weightlessness",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 2,
                Price = 600,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("a783bbe3-c90d-46c0-aa33-c1f7968ed238"), "You can spread this shimmering oil on an item of 1 Bulk or less to make it feel weightless. It has negligible Bulk for 1 hour.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5a590def-17d1-415b-84b9-8ecb443114cd"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
            
            yield return new OilVariant
            {
                Id = Guid.Parse("1e692f44-e3be-4791-b3d1-50cdd4b57c4a"),
                Name = "Oil of Weightlessness (Greater)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 6,
                Price = 3600,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d600de8f-ae83-4db0-8ee4-8947c860cca6"), "You can spread this shimmering oil on an item of 2 Bulk or less to make it feel weightless. It has negligible Bulk for 8 hours.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6adb5b0b-cf3f-4f9b-8baf-e9eaa60f6daa"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e8e259c8-d61a-43ef-a144-d109c92371a3"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("8f6bfdd0-9b6e-4419-855f-8a18a0f14a7d"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("aaafd030-1489-4fcc-ac58-d70bc022729c"), Traits.Instances.Oil.ID);
            builder.Add(Guid.Parse("b86c52ae-b20e-4fc3-8e11-26ff0720fb85"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c651cb66-c478-4f07-b45a-d9e1bae29015"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 562
            };
        }
    }
}
