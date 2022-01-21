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
    public class CheetahsElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("7a89776c-ffcc-4766-8ddb-d0d6f2227c30");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Cheetah's Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c3d0b8fa-4656-44c2-86ad-2247cc2326fd"), "Enzymatic compounds in this elixir strengthen and excite the muscles in your legs. You gain a status bonus to your Speed for the listed duration."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("fe4a4297-984f-492d-b46c-09a59eeadd81"),
                Name = "Cheetah's Elixir (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 300,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f0753443-182e-4208-8180-0da0fac92b11"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("cde56e4d-4678-4c01-8ab2-45b9abdb32a7"), "The bonus is +5 feet, and the duration is 1 minute.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("45cdabed-781e-4476-810d-3972cd2a68c1"),
                Name = "Cheetah's Elixir (Moderate)",
                Usage = "Held in 1 hand",
                Level = 5,
				Price = 2500,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("69bed6c8-4872-44ca-a5a4-363c6e349d2d"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("51d04f8e-e7fe-4d94-9194-e63b4271e318"), "The bonus is +10 feet, and the duration is 10 minutes.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("a5799229-afdb-4118-910f-000a05eb7681"),
                Name = "Cheetah's Elixir (Greater)",
                Usage = "Held in 1 hand",
                Level = 9,
				Price = 11000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3d678c45-f40e-40e1-b8f7-3d7becc265f9"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("77b16550-3aa7-4f52-b97d-c933a056a6ec"), "The bonus is +10 feet, and the duration is 1 hour.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4107088e-d895-4563-9d1b-764d08926fcc"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("59e3c105-4d3c-4942-9bd5-818b4ac5f6b8"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("d6ce495c-683a-4cf7-928a-c5cb2555138f"), Traits.Instances.Consumable.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35bda9da-c238-43e3-8446-b5e2ebefdae1"),
                SourceId = CoreRulebook.ID,
                Page = 547
            };
        }
    }
}
