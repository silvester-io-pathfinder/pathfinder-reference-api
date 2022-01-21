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
    public class ElixirOfLife : Template
    {
        public static readonly Guid ID = Guid.Parse("479d0265-a1a4-41f3-afd0-8ad618bdb7a6");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Elixir of Life",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("150dac7f-5e0c-461a-91ea-1d6b6cb5fda9"), "Elixirs of life accelerate a living creature's natural healing processes and immune system. Upon drinking this elixir, you regain the listed number of Hit Points and gain an item bonus to saving throws against diseases and poisons for 10 minutes."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("dacf4b83-8fb8-491a-b488-f58b96eab7d5"),
                Name = "Elixir of Life (Minor)",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 300,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Minor.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1ee995de-c0eb-43b7-a099-0cd86814a615"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5325b6bc-fac1-4c79-b2bd-b0dc548522cb"), "The elixir restores 1d6 Hit Points, and the bonus is +1.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("2baf4a62-f1e3-4960-ac8f-a60954b4c9e2"),
                Name = "Elixir of Life (Lesser)",
                Usage = "Held in 1 hand",
                Level = 5,
				Price = 3000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("719b7016-cca8-4d69-b1a5-ed3eaf807945"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("2fafc772-2720-4fb9-b356-38e13ddeb958"), "The elixir restores 3d6+6 Hit Points and the bonus is +1.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("a5bc4dfd-5e13-4005-b061-338b4c23826e"),
                Name = "Elixir of Life (Moderate)",
                Usage = "Held in 1 hand",
                Level = 9,
				Price = 15000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("7b9a5447-10f9-4696-9c9e-f0c79ad6083d"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ac101c07-1e31-4230-8896-49adaa93ae84"), "The elixir restores 5d6+12 Hit Points, and the bonus is +2.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("d6f46c03-c140-4c4c-8343-f1f4d0ad9b89"),
                Name = "Elixir of Life (Greater)",
                Usage = "Held in 1 hand",
                Level = 13,
				Price = 60000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("0ed80024-ff5a-495a-b84a-3a1ea6c99ad2"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("319a1a82-32e0-4801-a293-f32467a0854a"), "The elixir restores 7d6+18 Hit Points, and the bonus is +2.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("56e641d4-48b2-4487-a96e-5e7d301affa1"),
                Name = "Elixir of Life (Major)",
                Usage = "Held in 1 hand",
                Level = 15,
				Price = 130000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("74fa8ed4-e9f7-454f-9051-2b549ae39495"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0ff9dc91-4925-4dd0-99f6-0c5d95f60a81"), "The elixir restores 8d6+21 Hit Points, and the bonus is +3.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("6b62bddc-b7e5-49cf-8379-67c972f83dd4"),
                Name = "Elixir of Life (True)",
                Usage = "Held in 1 hand",
                Level = 19,
				Price = 800000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.True.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8055268d-f52b-4a1a-a649-6e4f624aa1bd"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("f852d024-330f-4ac6-8e11-87e779d2b1d3"), "The elixir restores 10d6+27 Hit Points, and the bonus is +4.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("74ea3344-6466-4c05-a174-f3705828b923"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("97f676e9-0939-442c-8b7c-6d14f16122f9"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("43085b4a-0f94-4d05-af66-2b6f428d8280"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("23e4df3b-d8ed-4535-9746-cb1c05605606"), Traits.Instances.Healing.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbefcb2c-8c92-4afa-9bfe-14df0480ea74"),
                SourceId = CoreRulebook.ID,
                Page = 548
            };
        }
    }
}
