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
    public class BombersEyeElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("c1fbd9e7-e36e-49d7-b3c2-772400e1fc5e");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Bomber's Eye Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("47c254c1-8659-4363-8818-143300056126"), "This tincture lets you pinpoint your foes. For the next 5 minutes, your alchemical bomb Strikes reduce the circumstance bonus to AC your targets gain from cover."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("e87ddbd9-2e31-4b10-b0db-07f4d4ca71c9"),
                Name = "Bomber's Eye Elixir (Lesser)",
                Usage = "Held in 1 hand",
                Level = 4,
				Price = 1400,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("fde3d34f-549b-4bca-8bd5-20e511970705"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("f62b8e76-fc79-40f5-a7da-c90084441211"), "Reduce your targets' circumstance bonus by 1.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("1c6bf9da-9e46-4f5e-9703-5d48a5a59f73"),
                Name = "Bomber's Eye Elixir (Greater)",
                Usage = "Held in 1 hand",
                Level = 14,
				Price = 70000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("424eb645-ef8a-460a-97b9-73bdba657b89"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("65028d2d-0cb0-45ce-85a9-ba7bb2a10aa9"), "Reduce your targets' circumstance bonus by 2.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("94f60218-9a70-4687-bedf-49dd77d51a68"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("6b7d6f66-69ca-4848-854d-f7c5bd0dbd0e"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("381adfa7-afeb-4093-bbe2-a33b6b63e686"), Traits.Instances.Consumable.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("059586d6-6a3c-4369-b92b-4f589f1d0323"),
                SourceId = CoreRulebook.ID,
                Page = 547
            };
        }
    }
}
