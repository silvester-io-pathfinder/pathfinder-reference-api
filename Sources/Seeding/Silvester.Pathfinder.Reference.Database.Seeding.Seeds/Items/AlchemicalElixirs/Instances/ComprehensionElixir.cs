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
    public class ComprehensionElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("787a099b-e070-4e58-b0b7-89c5e2f0aac9");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Comprehension Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("99f4909b-5fd9-4602-abb9-84a2309b4879"), "This bitter draft opens your mind to the potential of the written word. For the listed duration after drinking this elixir, you can understand any words you read, so long as they are written in a common language. This elixir doesn't automatically allow you to understand codes or extremely esoteric passages—you still need to attempt a skill check to Decipher Writing."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("f6d92417-5da6-46d8-b455-adf5d1a6e6ac"),
                Name = "Comprehension Elixir (Lesser)",
                Usage = "Held in 1 hand",
                Level = 2,
				Price = 700,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("bfd888a9-81b6-4181-9c9c-21927c18d2ce"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6810ce88-53a6-4404-9a76-2e63a3ffcd79"), "The duration is 1 minute.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("557a7b9c-4525-4792-a089-0cd90884bef7"),
                Name = "Comprehension Elixir (Greater)",
                Usage = "Held in 1 hand",
                Level = 7,
				Price = 5400,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("eca340aa-2911-4c26-ac04-dd6ba04c5576"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("3c0316a5-d191-49d2-b374-adba0bb38500"), "The duration is 10 minutes.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5336f2b5-75f5-43b3-a3cd-2cbadc28fe39"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("ac983889-3a23-4c54-9b99-975e1ec55e0b"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("4f170015-27df-475d-9dca-f1d2dd69f023"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("d39c0371-58f2-4866-80a1-6d93abaaa6cc"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e859dce4-cd01-4326-816e-c966ccc2a34b"),
                SourceId = CoreRulebook.ID,
                Page = 547
            };
        }
    }
}
