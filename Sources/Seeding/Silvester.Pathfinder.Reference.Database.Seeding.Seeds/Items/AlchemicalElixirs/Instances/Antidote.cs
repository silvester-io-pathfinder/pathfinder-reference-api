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
    public class Antidote : Template
    {
        public static readonly Guid ID = Guid.Parse("6f8d51ab-686a-4694-8265-6a8ecbdcd4ef");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Antidote",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d1bb984c-ccab-4264-8aa3-435485016200"), "An antidote protects you against toxins. Upon drinking an antidote, you gain an item bonus to Fortitude saving throws against poisons for 6 hours."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("91e489a0-7ef5-4a99-a472-802d33bdc287"),
                Name = "Antidote (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 300,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d9254758-924e-4746-8a2b-f708478267c5"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("e0049cf0-12b6-4647-95b7-acdaa198dce7"), "You gain a +2 item bonus.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("2370caa4-9066-40bc-88b7-32e04a327933"),
                Name = "Antidote (Moderate)",
                Usage = "Held in 1 hand",
                Level = 6,
				Price = 3500,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ddbe270c-80cc-4299-a468-f17712a39251"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("9cf5b303-a4a0-4d63-8a42-b705d195fff5"), "You gain a +3 item bonus.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("b9ab7cea-80de-4a33-8fe9-6557f6457001"),
                Name = "Antidote (Greater)",
                Usage = "Held in 1 hand",
                Level = 10,
				Price = 16000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4c9d8586-c9ae-4246-ac8e-a6e9f290f6a5"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("24d4bc30-fb5e-48b0-89c7-877def7b66b6"), "You gain a +4 item bonus.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("7ce83360-946a-414e-b98f-833713b8227c"),
                Name = "Antidote (Major)",
                Usage = "Held in 1 hand",
                Level = 14,
				Price = 67500,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("aeb2411a-64b4-4e71-b62a-8b9c3653b93a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("11c4131f-00b8-4f2d-b81d-e2051cdb60cc"), "You gain a +4 item bonus, and when you drink the antidote, you can immediately attempt a save against one poison of 14th level or lower affecting you. If you succeed, the poison is neutralized.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("df9b95f3-6f68-45c7-be31-dc330ab01ca1"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("457ed5d8-1e4c-4238-9298-47111fc7ef74"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("3a123db1-6585-4328-8317-5dc4dd8ae254"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("dcbb524a-3e3e-46c3-9616-d98c340c9a14"), Traits.Instances.Healing.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60b5a304-6259-494b-93a5-92fe962745be"),
                SourceId = CoreRulebook.ID,
                Page = 546
            };
        }
    }
}
