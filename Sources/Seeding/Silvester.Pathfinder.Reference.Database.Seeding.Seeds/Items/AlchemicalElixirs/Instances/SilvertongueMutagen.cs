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
    public class SilvertongueMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("a4700423-ee77-4ed2-ac68-682da90db27b");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Silvertongue Mutagen",
                Benefit = "You gain an item bonus to Deception, Diplomacy, Intimidation, and Performance checks. Your critical failures with any of these skills become failures instead.",
                Drawback = "You take a –2 item penalty to Arcana, Crafting, Lore, Occultism, and Society checks. Choose one skill in which you are trained; for the duration, you become untrained in that skill. All your failures on checks to Recall Knowledge become critical failures.",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9b681339-c92a-45b5-9bed-aebedf317e72"), "Your features become striking and your voice becomes musical and commanding, though facts and figures become hazy for you and emotion clouds your ability to reason."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("b056b057-9364-483b-bdba-4cfe7def1f5e"),
                Name = "Silvertongue Mutagen (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 400,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("97edf966-7f7f-4daf-906c-b18fc1fdbfd1"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("f5361bdc-3cbb-412c-b593-4c6e6aecb985"), "The bonus is +1, and the duration is 1 minute.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("8ce0fa7d-20be-4e6f-a187-ec5dea1195d4"),
                Name = "Silvertongue Mutagen (Moderate)",
                Usage = "Held in 1 hand",
                Level = 3,
				Price = 1200,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("eabcf894-6466-46e5-aa36-312e9e3bb96a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("71411d5f-5f61-4ed4-b015-e474223dbb48"), "The bonus is +2, and the duration is 10 minutes.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("3dfcbecf-41ba-4742-b096-fab4c9d371bc"),
                Name = "Silvertongue Mutagen (Greater)",
                Usage = "Held in 1 hand",
                Level = 11,
				Price = 30000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6defbf5e-d382-45fe-a7b3-5e4baa902484"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5751d1ff-2477-4509-94ef-f1bc4d8c7f3b"), "The bonus is +3, and the duration is 1 hour.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("0ac53999-7bc7-4e2d-a23c-528b063faf68"),
                Name = "Silvertongue Mutagen (Major)",
                Usage = "Held in 1 hand",
                Level = 17,
				Price = 300000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f53b10c9-8b5c-42ce-ab1e-42248505fe33"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("72d5ff26-d6f7-4fd5-9e64-aa4c62ee4d21"), "The bonus is +4, and the duration is 1 hour.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("28f52b66-4ed3-429d-8b7f-f1632a4f7af2"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("7cbebc05-b244-4a67-80c6-f6433885eb75"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("e70bceab-1ec2-4eb2-a26a-bcfcae164dce"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("64061126-3b7e-4dc9-acf4-de9279f50a94"), Traits.Instances.Mutagen.ID);
            builder.Add(Guid.Parse("84034927-eda5-409a-8dd9-9e8ecd0bc08f"), Traits.Instances.Polymorph.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1960b59-9b61-4f34-adbb-3ce997fc0fda"),
                SourceId = CoreRulebook.ID,
                Page = 550
            };
        }
    }
}
