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
    public class Antiplague : Template
    {
        public static readonly Guid ID = Guid.Parse("c0369185-db16-46ad-9ac7-c4e269e9a0a8");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Antiplague",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("743b8c94-0516-4c3d-9c02-6e54afceab7d"), "Antiplague can fortify the body's defenses against diseases. Upon drinking an antiplague, you gain an item bonus to Fortitude saving throws against diseases for 24 hours; this applies to your daily save against a disease's progression."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("4154b59f-698b-4491-804b-e00f53decb63"),
                Name = "Antiplague (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 300,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e7789613-99bb-4e3c-840b-d1532cb3bb76"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("b81d6ef9-8b3b-4f34-901b-5a46f9e47a76"), "You gain a +2 item bonus.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("1696086f-6b34-4562-adb4-82a41ff3c7b0"),
                Name = "Antiplague (Moderate)",
                Usage = "Held in 1 hand",
                Level = 6,
				Price = 3500,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("124f8856-d238-4a5f-bef2-3440f317398a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("137b3918-d439-4380-b25a-6ae3d5ffd48d"), "You gain a +3 item bonus.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("2070f995-d30d-49df-b813-74f5e86fee94"),
                Name = "Antiplague (Greater)",
                Usage = "Held in 1 hand",
                Level = 10,
				Price = 16000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("50dbba0e-9c78-4a55-a902-31cccd195a7e"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("875d3874-e5fd-418b-8005-49a43354c38e"), "You gain a +4 item bonus.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("0415f0aa-1460-4dd3-9c11-2ce089552a15"),
                Name = "Antiplague (Major)",
                Usage = "Held in 1 hand",
                Level = 14,
				Price = 67500,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ff5a743d-0ce1-443e-9d09-91dc4bc7c03a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("986a17b7-4334-4304-8021-c85caf0b35d2"), "You gain a +4 item bonus, and when you drink the antiplague, you can immediately attempt a saving throw against one disease of 14th level or lower affecting you. If you succeed, you are cured of the disease.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d37650d7-8253-4c61-8325-37f25d7da939"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("651b563c-00fb-42e9-bf53-12824fd10bc6"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("f03907d4-9803-47cd-95a9-ec5a336d75a5"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("4f185062-fe5d-41dd-bd90-c5185d9b164a"), Traits.Instances.Healing.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ef3438b-f3b0-4362-85bf-3d1f55ec01ac"),
                SourceId = CoreRulebook.ID,
                Page = 546
            };
        }
    }
}
