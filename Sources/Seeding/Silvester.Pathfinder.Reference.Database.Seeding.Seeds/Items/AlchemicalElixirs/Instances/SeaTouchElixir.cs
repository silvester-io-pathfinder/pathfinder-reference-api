using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalElixirs.Instances
{
    public class SeaTouchElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("ceaaac90-8340-4e2a-aa97-effc5848f12d");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Sea Touch Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5d023119-60ec-4f88-9056-c3b81e0af2bf"), "This briny concoction alters the skin on your hands and feet. The spaces between your fingers and toes become webbed, granting you a swim Speed of 20 feet for the listed duration."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("b9e3fce6-156b-4ff8-b412-81d3250d6713"),
                Name = "Sea Touch Elixir (Lesser)",
                Usage = "Held in 1 hand",
                Level = 5,
				Price = 2200,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b5e9c410-4584-4cac-bbf7-ba8303a2e066"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5b8e7b34-f58a-4c20-8572-ca985e3e485b"), "The duration is 10 minutes.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("8f3626ff-346a-4eb1-ad3b-82ac2c1060f4"),
                Name = "Sea Touch Elixir (Moderate)",
                Usage = "Held in 1 hand",
                Level = 12,
				Price = 30000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1d16cc63-7013-4b7e-b06e-8a324c0323e4"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("18506369-f48b-4db3-a09e-3ec45bf0572b"), "The duration is 1 hour, and you can breathe underwater.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("e76fa208-fe2c-41f5-8cf6-21c46064a190"),
                Name = "Sea Touch Elixir (Greater)",
                Usage = "Held in 1 hand",
                Level = 15,
				Price = 92000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f974f506-ae77-4393-bcfc-a828b4ac8730"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c91b3131-50bc-45e9-8b02-d505ef101cc3"), "The duration is 24 hours, and you can breathe underwater.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7588624e-d7e8-4998-a03f-62a897904a1d"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("85385fdb-1eba-48c2-9f35-c646f7638264"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("95438f54-051f-44b7-9677-289bf8c666c4"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("d5cfd571-886e-4bf4-91e4-327b71affcf8"), Traits.Instances.Polymorph.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a83ecdc-9097-475c-a98e-1240f6dda74b"),
                SourceId = CoreRulebook.ID,
                Page = 549
            };
        }
    }
}
