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
    public class SereneMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("baf67e26-cdcd-48fc-b64a-2e68c08bef03");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Serene Mutagen",
                Benefit = "You gain an item bonus to Will saves and Perception, Medicine, Nature, Religion, and Survival checks. This bonus improves when you attempt Will saves against mental effects.",
                Drawback = "You take a –1 penalty to attack rolls and save DCs of offensive spells, and a –1 penalty per damage die to all weapon, unarmed attack, and spell damage.",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("26d53eae-b1d3-4e3c-81d1-83d6d86633df"), "You gain inner serenity, focused on fine details and steeled against mental assaults, but you find violence off-putting."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("4ddd60e2-ca4d-4083-abb2-e59eba12ebc9"),
                Name = "Serene Mutagen (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 400,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d57bb0a0-c7ea-4251-b9ab-3edd0029e1ff"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("959d6276-ed2f-4aab-8511-16987b76ef34"), "The bonus is +1, or +2 vs. mental, and the duration is 1 minute.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("34301c2f-2b01-465c-bdf2-e7b562745d59"),
                Name = "Serene Mutagen (Moderate)",
                Usage = "Held in 1 hand",
                Level = 3,
				Price = 1200,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("02453887-e5a9-44bd-972b-297a8d4d75c3"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("efbb0f74-0838-40c9-953f-ae05962b599c"), "The bonus is +2, or +3 vs. mental, and the duration is 10 minutes.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("a181f368-f4e7-4dc9-add0-f8fd91c1e82e"),
                Name = "Serene Mutagen (Greater)",
                Usage = "Held in 1 hand",
                Level = 11,
				Price = 30000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b446ec15-5bee-4f32-99a3-74606d46881c"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("26cbe305-3adc-4893-8759-e2af4d9f678a"), "The bonus is +3, or +4 vs. mental, and the duration is 1 hour. When you roll a success on a Will save against a mental effect, you get a critical success instead.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("c25492a4-eb51-4284-9322-13910d9cd42b"),
                Name = "Serene Mutagen (Major)",
                Usage = "Held in 1 hand",
                Level = 17,
				Price = 3000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f1200ab8-0ec9-4ced-aae5-22ecfb6a4796"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("bcee3040-41bd-43dc-afe4-907c2c26b691"), "The bonus is +4, and the duration is 1 hour. When you roll a success on a Will save against a mental effect, you get a critical success instead, and your critical failures on Will saves against mental effects become failures instead.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9f4fb9c1-fe9f-4c2a-a0af-cf2cdc3ff9f4"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("bfc7cca3-0a62-4e02-a150-d87b5163885b"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("f662e2f2-cf56-4fb0-9c52-690c4b9a7526"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("819437dc-71c8-4df2-908a-59193babf7ce"), Traits.Instances.Mutagen.ID);
            builder.Add(Guid.Parse("1affe511-313d-4757-af9d-be161b4bb4b4"), Traits.Instances.Polymorph.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94b98608-9ba0-46c2-9793-e5421daeb22a"),
                SourceId = CoreRulebook.ID,
                Page = 549
            };
        }
    }
}
