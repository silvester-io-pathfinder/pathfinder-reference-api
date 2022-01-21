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
    public class QuicksilverMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("eeca589b-c156-4a4a-8614-d78cc53934c1");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Quicksilver Mutagen",
                Benefit = "You gain an item bonus to Acrobatics checks, Stealth checks, Thievery checks, Reflex saves, and Dexterity-based attack rolls, and you gain the listed status bonus to your Speed.",
                Drawback = "You take damage equal to twice your level; you can't recover Hit Points lost in this way by any means while the mutagen lasts. You take a –2 penalty to Fortitude saves.",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ad64a881-6dc8-4752-8c71-e3486b4977bc"), "Your features become thin and angular. You become swifter and nimbler, but your body also becomes fragile."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("598c5a4c-6040-442d-bbf2-7f21e072a143"),
                Name = "Quicksilver Mutagen (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 400,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("31442180-9e14-4d48-a0a2-0d3fc8d19a66"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("909a890e-0ac7-4a7c-99d5-5f6148445213"), "The bonus to rolls is +1, the bonus to Speed is +5 feet, and the duration is 1 minute.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("68101420-8854-4e3c-a8cc-3ff62b531a13"),
                Name = "Quicksilver Mutagen (Moderate)",
                Usage = "Held in 1 hand",
                Level = 3,
				Price = 1200,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("da589f9c-4c58-474a-bd18-b91e9398b516"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ad0a8f9d-6756-4d8d-a4f6-ea0736c42cb6"), "The bonus to rolls is +2, the bonus to Speed is +10 feet, and the duration is 10 minutes.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("d57cc4b4-6527-45cd-8fbf-cb1574460ed0"),
                Name = "Quicksilver Mutagen (Greater)",
                Usage = "Held in 1 hand",
                Level = 11,
				Price = 30000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("dd5f747e-d5cd-4979-aa65-9afa84f2d718"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("01e07fd2-39d2-489b-b033-93a01c219af2"), "The bonus to rolls is +3, the bonus to Speed is +15 feet, and the duration is 1 hour.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("c4b8ef3f-b0ba-4fbc-92e1-a4824ccd8713"),
                Name = "Quicksilver Mutagen (Major)",
                Usage = "Held in 1 hand",
                Level = 17,
				Price = 300000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d743d706-0044-4816-88b8-0872efb48ad3"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("7efae01d-66de-4b2a-872e-64a3f1e39b23"), "The bonus to rolls is +4, the bonus to Speed is +20 feet, and the duration is 1 hour.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("fce5b3aa-b25e-4532-8cf2-277d056bfbe1"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("941e3c7e-3143-4a34-a390-f7f69aaa16b0"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("13bf3ceb-748a-40a7-99d4-2d821a30bf4a"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("b8d5718b-222e-44da-9b34-c3eb8dfc8a5b"), Traits.Instances.Mutagen.ID);
            builder.Add(Guid.Parse("48f0632e-1a3a-489a-9500-fdfde5b90853"), Traits.Instances.Polymorph.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fbd3dd2-ede6-4021-8311-36ea949ff120"),
                SourceId = CoreRulebook.ID,
                Page = 549
            };
        }
    }
}
