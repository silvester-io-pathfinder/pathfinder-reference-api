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
    public class SalamanderElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("edf0d3e8-4400-4feb-8326-7d98976ebae7");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Salamander Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e5afe368-8abd-4cc4-b15a-fe449c96daac"), "This elixir is made from salamander scales to withstand fire. For 24 hours, you are protected from the effects of severe heat."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("56b36a36-b64e-4971-83e3-0731620051d1"),
                Name = "Salamander Elixir (Lesser)",
                Usage = "Held in 1 hand",
                Level = 4,
				Price = 1500,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("83d39e74-fc68-468f-b6e0-b400c29ff84a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("4860186d-2384-449c-bb5e-446be9be551c"), "No explicit benefits are listed for the Lesser potency.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("f140633a-a10d-4792-a020-e8ac3d207dff"),
                Name = "Salamander Elixir (Moderate)",
                Usage = "Held in 1 hand",
                Level = 12,
				Price = 32000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("bde8f7d4-6deb-4290-85c2-8c07ddfc3d30"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("b6ddd593-201a-4a8a-ac49-7116b7576459"), "You're also protected from extreme heat.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("8d9cceea-4f0e-4059-a024-b7873621fca6"),
                Name = "Salamander Elixir (Greater)",
                Usage = "Held in 1 hand",
                Level = 16,
				Price = 140000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("05556731-a1a0-43fc-bdd7-60e976af9af1"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("640c77cd-521f-45ff-a5de-c579c59bd5bc"), "You're also protected from extreme and incredible heat.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ef1e2fda-d707-4f61-ac6c-6ad4fb3abb82"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("4cf189de-2531-48bf-893c-ca3f46661366"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("a2296dc8-0380-4e1f-b3b0-80cd723655db"), Traits.Instances.Consumable.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba706507-3628-4a2c-815b-cdb54e373a88"),
                SourceId = CoreRulebook.ID,
                Page = 549
            };
        }
    }
}
