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
    public class MistformElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("87e2ed9e-5358-493d-be9f-0f96150b5b7a");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Mistform Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("518dfefb-b42e-457a-a7f2-df253f733f15"), "A faint mist emanates from your skin, making you concealed for the listed duration. As usual, if you become concealed when your position is still obvious, you can't use this concealment to Hide or Sneak."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("26b6036e-5be6-4998-a4cb-7e5eb4580f42"),
                Name = "Mistform Elixir (Lesser)",
                Usage = "Held in 1 hand",
                Level = 4,
				Price = 1800,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("462e670f-a3ff-47dc-980f-acd93f0abce7"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5ae44f5b-802b-4403-aece-2ea808a4f485"), "The duration is 3 rounds.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("682c3083-33ff-4b69-b25c-1a249a9d81cd"),
                Name = "Mistform Elixir (Moderate)",
                Usage = "Held in 1 hand",
                Level = 6,
				Price = 5600,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("bde08cbc-9bf4-4283-9e26-4d0e27fa5bdf"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c41cf691-b8b4-429f-8eb2-c986f4aebb2b"), "The duration is 1 minute.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("70eda229-1d6e-4e66-9adf-6dc941b35eb8"),
                Name = "Mistform Elixir (Greater)",
                Usage = "Held in 1 hand",
                Level = 10,
				Price = 18000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("134df6ea-d75a-4fa2-b817-9b6c6e58051a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d2a61403-6783-4d1d-bc86-63040164d26b"), "The duration is 5 minutes.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("dc0d82f7-7c79-494f-af29-be51c66712dc"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("19dbc1dd-9946-4a64-b85b-f951ca0fdf5c"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("3b09f2ac-d524-4a28-b5ee-4332517f378d"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("ccd6967f-e436-4411-954b-79628e53c378"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("2fea4587-e7f0-4f13-974e-7d6a309fa1b3"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39900b0b-1dab-41b8-93bf-4af4fa597e8b"),
                SourceId = CoreRulebook.ID,
                Page = 549
            };
        }
    }
}
