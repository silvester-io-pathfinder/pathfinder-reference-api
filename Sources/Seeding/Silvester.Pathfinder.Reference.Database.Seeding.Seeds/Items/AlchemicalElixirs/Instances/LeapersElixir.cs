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
    public class LeapersElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("fce1d931-7808-4e03-8615-f9f0210c405a");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Leaper's Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("83785b35-3536-4517-8ad1-e06c530cba25"), "This tingly solution increases the elasticity and contraction of your leg muscles. For 1 minute after drinking this elixir, you can High Jump or Long Jump as a single action instead of 2 actions. If you do, you don't perform the initial Stride (nor do you fail if you don't Stride 10 feet)."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("7e27f203-866b-4aa0-aa90-eac4ddeb63dd"),
                Name = "Leaper's Elixir (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 300,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5cb84996-bc79-4c47-a78b-a8453db3b9d4"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("9d34e1d6-ff1e-4d2a-b65b-5a03606c60b7"), "No explicit benefits are listed for the Lesser potency.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("cb54c6f2-efc7-4075-b4eb-441986ce1558"),
                Name = "Leaper's Elixir (Greater)",
                Usage = "Held in 1 hand",
                Level = 7,
				Price = 3500,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9662df8f-7b91-4916-a9ab-d543004539c1"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("11578ca2-020a-435b-8096-d4dca1b88edf"), "The maximum vertical distance you can jump with a High Jump is the same as you can jump horizontally with a Long Jump.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("073a8586-f6c6-4e5d-82ac-8ac9a2453089"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("ddab84df-9008-46da-90e3-7aab3135a932"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("a0ed9964-9544-4aa4-ac44-aba36c314a3d"), Traits.Instances.Consumable.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb4cba35-f753-4922-b078-0dfbcff780f2"),
                SourceId = CoreRulebook.ID,
                Page = 549
            };
        }
    }
}
