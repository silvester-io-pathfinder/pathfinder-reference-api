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
    public class JuggernautMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("64cc1e8c-d5c1-4e58-9306-3be2e06a95b9");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Juggernaut Mutagen",
                Benefit = "You gain an item bonus to Fortitude saves and the listed number of temporary Hit Points. Whenever you are at maximum Hit Points for at least 1 full minute, you regain the temporary Hit Points.",
                Drawback = "You take a –2 penalty to Will saves, Perception checks, and initiative rolls.",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("04d5224a-86f5-4533-a931-a1b465cbac1c"), "After you drink this mutagen, your body becomes thick and sturdy. You exhibit a healthy glow, though you tend to be ponderous and unobservant."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("1b1ff22d-3fa6-478f-baec-36db27dc91f9"),
                Name = "Juggernaut Mutagen (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 400,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b110571d-5abd-46a4-9449-97d0fb9c6a91"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("75f90dc9-aa73-4d7a-9ff3-6c3584c8989b"), "The bonus is +1, you gain 5 temporary Hit Points, and the duration is 1 minute.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("7784be12-0f34-455d-83cd-a77ed2ccc458"),
                Name = "Juggernaut Mutagen (Moderate)",
                Usage = "Held in 1 hand",
                Level = 3,
				Price = 1200,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("dc2e6865-c36f-46ef-b018-461443e9b9d4"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("3976b9c5-7566-442b-905c-6026ada53ca8"), "The bonus is +2, you gain 10 temporary Hit Points, and the duration is 10 minutes.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("8ae2a6d5-6e36-48ae-b1bb-41698dd0803d"),
                Name = "Juggernaut Mutagen (Greater)",
                Usage = "Held in 1 hand",
                Level = 11,
				Price = 30000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("16daf65d-179a-48df-b7fa-f6f89872a141"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ddf19bf0-291a-49f9-965f-92969fbda261"), "The bonus is +3, you gain 30 temporary Hit Points, and the duration is 1 hour. When you roll a success on a Fortitude save, you get a critical success instead.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("c10dc1eb-97c5-40ea-9aa3-ca19b2f701ee"),
                Name = "Juggernaut Mutagen (Major)",
                Usage = "Held in 1 hand",
                Level = 17,
				Price = 300000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3e53e35d-5a87-46a9-ac51-0026776b7158"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6588822e-f691-44a4-a47f-f6b8de44a3ff"), "The bonus is +4, you gain 45 temporary Hit Points, and the duration is 1 hour. When you roll a success on a Fortitude save, you get a critical success instead, and your critical failures on Fortitude saves become failures instead.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5c57839f-5b5e-4187-86ab-97edbd206b83"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("28548fb5-3ed5-4ef7-aa7b-26c1cd7a8ef5"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("43050637-e979-48b2-9fcc-97e8e82863be"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("b50af386-eeac-480d-8e4b-afe243ab5c4b"), Traits.Instances.Mutagen.ID);
            builder.Add(Guid.Parse("1cf8c33c-6ea4-4581-afba-a092c06bb1ac"), Traits.Instances.Polymorph.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c10dc1eb-97c5-40ea-9aa3-ca19b2f701ee"),
                SourceId = CoreRulebook.ID,
                Page = 548
            };
        }
    }
}
