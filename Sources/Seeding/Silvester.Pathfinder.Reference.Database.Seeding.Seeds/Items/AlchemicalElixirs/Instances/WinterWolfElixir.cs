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
    public class WinterWolfElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("b28f4309-cc04-4522-8837-b653995b3028");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Winter Wolf Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7b92f530-d78e-4683-b967-9de524ac2063"), "This elixir warms your core and improves your circulation. For 24 hours, you are protected from the effects of severe cold."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("f9db054b-d24c-44d4-b52e-540188a3a862"),
                Name = "Winter Wolf Elixir (Lesser)",
                Usage = "Held in 1 hand",
                Level = 4,
				Price = 1500,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("955bafcb-2735-4cf1-aab8-4aaf8a3b9c76"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("67cc0a6c-0d6a-4598-aba9-1913ebdb4983"), "No explicit benefits are listed for the Lesser potency.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("1d957ae5-0642-40d9-8f2d-8d8496975a6d"),
                Name = "Winter Wolf Elixir (Moderate)",
                Usage = "Held in 1 hand",
                Level = 12,
				Price = 32000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8dcd9d61-aacf-47f8-a2b5-5cc3c85693cc"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("34ebdce4-c1d3-4161-bcb6-1bf7ee1c700b"), "You're also protected from extreme cold.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("c62e9b49-532a-474f-8dfe-1cd38fd4c6a5"),
                Name = "Winter Wolf Elixir (Greater)",
                Usage = "Held in 1 hand",
                Level = 16,
				Price = 140000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5a7863ed-cb72-45ba-adff-534a05e92980"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("1201f0db-da86-41f3-ae52-5d5eb3ea64c3"), "You're also protected from extreme and incredible cold.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("22d7c2d4-1df3-4516-a126-74ae3f4ca012"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("1546a5a6-a646-4adf-aeee-865be2f90305"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("25005c99-f1a2-422d-8fea-7728104d7683"), Traits.Instances.Consumable.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df8b0c80-d477-4466-9d2d-5e632c0380a3"),
                SourceId = CoreRulebook.ID,
                Page = 550
            };
        }
    }
}
