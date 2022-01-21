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
    public class EagleEyeElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("e81eb16e-db86-4869-9cc7-1b5dfa3ba787");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Eagle-Eye Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fc565a61-6754-4bea-bdc6-768b53993621"), "After you drink this elixir, you notice subtle visual details. For the next hour, you gain an item bonus to Perception checks that is greater when attempting to find secret doors and traps."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("b38c09ea-4d70-41b1-8abe-f1e564fca8f6"),
                Name = "Eagle-Eye Elixir (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 400,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8e654dc0-0f43-4bd1-80af-098cec872937"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c8f62b0c-e2b2-4108-bbac-fe179d03af55"), "The bonus is +1, or +2 to find secret doors and traps.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("8a7a3827-e85a-4640-8ac2-e8ee126c858c"),
                Name = "Eagle-Eye Elixir (Moderate)",
                Usage = "Held in 1 hand",
                Level = 5,
				Price = 2700,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("bc686e3f-7493-4792-a0bf-f3e30e5dfb52"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("617976b0-6d52-4d92-81c3-2fb47eb1c769"), "The bonus is +2, or +3 to find secret doors and traps.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("088a145b-55c6-498a-84fe-19a05c03b0aa"),
                Name = "Eagle-Eye Elixir (Greater)",
                Usage = "Held in 1 hand",
                Level = 10,
				Price = 20000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("09026902-83c9-4de1-960f-24be13a70ebf"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5f79e35f-5ce9-4747-978e-652513ad512e"), "The bonus is +3, or +4 to find secret doors and traps.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("f40a6267-87fa-4c89-a824-2dc1a54e2b55"),
                Name = "Eagle-Eye Elixir (Major)",
                Usage = "Held in 1 hand",
                Level = 16,
				Price = 200000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("81366cde-af17-47c7-adc5-265ae5299d9d"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("eb4df9d7-21c6-401e-9954-a4bd44c381f2"), "The bonus is +3, or +4 to find secret doors and traps. Each time you pass within 10 feet of a secret door or trap, the GM automatically rolls a secret check for you to find it.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8498628f-4eb9-41f2-b32c-e5f0176776f8"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("34442eee-98e9-4746-849b-16f0f039f694"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("1da006a2-6112-4d98-8258-b9e459d1f03d"), Traits.Instances.Consumable.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45fac17c-ce11-475b-9f6d-fd2b4fabcee4"),
                SourceId = CoreRulebook.ID,
                Page = 548
            };
        }
    }
}
