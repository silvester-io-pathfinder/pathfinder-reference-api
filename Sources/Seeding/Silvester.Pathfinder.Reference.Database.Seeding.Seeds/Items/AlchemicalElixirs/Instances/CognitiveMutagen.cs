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
    public class CognitiveMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("4ef08665-b07b-4ced-8876-ef6a15229e17");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Cognitive Mutagen",
                Benefit = "You gain an item bonus to Arcana, Crafting, Lore, Occultism, and Society checks and all checks to Recall Knowledge. Your critical failures on Recall Knowledge checks become failures instead.",
                Drawback = "You take a –2 penalty to weapon and unarmed attack rolls, Athletics checks, and Acrobatics checks. You can carry 2 less Bulk than normal before becoming encumbered, and the maximum Bulk you can carry is reduced by 4.",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e0308f62-e9c4-49b4-ab1e-864a77807cd9"), "Your mind becomes clear and cognition flows freely, but physical matters seem ephemeral."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("6a806118-bb1b-4a48-9c61-25cdfb30a144"),
                Name = "Cognitive Mutagen (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 400,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("15df47ff-3a03-45fa-9629-d0de294b0881"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0ce75ff2-9a7c-4cd9-b08d-6b3ff2928ef9"), "The bonus is +1, and the duration is 1 minute.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("05a6d03b-b652-4c46-bad5-5ed99753462a"),
                Name = "Cognitive Mutagen (Moderate)",
                Usage = "Held in 1 hand",
                Level = 3,
				Price = 1200,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("fe4d7004-65d3-4c57-a0eb-89f399a77404"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("9109221f-830c-493d-85d3-a0b2b18f67c7"), "The bonus is +2, and the duration is 10 minutes.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("f34b854e-2b01-426c-8fcc-17a23d7fcd4e"),
                Name = "Cognitive Mutagen (Greater)",
                Usage = "Held in 1 hand",
                Level = 11,
				Price = 30000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("cefb51d2-ece6-4dc3-a252-03503a10310a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("4328df92-b76e-47f3-8b67-3eea6c714088"), "The bonus is +3, and the duration is 1 hour. You become trained in one Intelligence-based skill, chosen at creation.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("543ebd11-59d5-4174-b8f8-8710b5b4a336"),
                Name = "Cognitive Mutagen (Major)",
                Usage = "Held in 1 hand",
                Level = 17,
				Price = 300000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e302cf94-4d97-470d-8372-e1366d6a01af"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("64bc6c43-f4b8-4407-bb24-15477c69e1ab"), "The bonus is +4, and the duration is 1 hour. You become trained in one skill, chosen at creation.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4ff98a86-d469-4414-8d61-1cd6d9dcb9fb"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("9ac5aabb-783d-49d2-bbff-c17551de7b13"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("e95f93ee-793a-4098-871f-4a8b01f2efdd"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("14435f4c-dc33-4e40-b12f-3244f959dadb"), Traits.Instances.Mutagen.ID);
            builder.Add(Guid.Parse("3a92538d-4edf-468f-90cb-814bb78de1f8"), Traits.Instances.Polymorph.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dfbada3b-aff5-4d11-bdae-51982a4d79a3"),
                SourceId = CoreRulebook.ID,
                Page = 547
            };
        }
    }
}
