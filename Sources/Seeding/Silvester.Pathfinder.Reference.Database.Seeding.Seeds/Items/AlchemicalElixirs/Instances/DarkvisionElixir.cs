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
    public class DarkvisionElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("82b662fa-09dc-4cc6-a7e1-13085af44f63");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Darkvision Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("47860fc7-facb-4704-b219-ff432eb33b73"), "After you drink this elixir, your sight becomes sharper in darkness.You gain darkvision for the listed duration."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("83e0b9b4-2eb9-4424-a262-d2deb9180d59"),
                Name = "Darkvision Elixir (Lesser)",
                Usage = "Held in 1 hand",
                Level = 2,
				Price = 600,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b589c1fb-ea6f-49e7-9395-7bbc82d0006e"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("104cf0a9-3ea7-4c0b-ae52-1d9e2b4ed295"), "The duration is 10 minutes.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("f2649e17-28ff-4859-8121-3f4ad7a0770d"),
                Name = "Darkvision Elixir (Moderate)",
                Usage = "Held in 1 hand",
                Level = 4,
				Price = 1100,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b1f4000d-d824-4b14-a58b-732a606f1448"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("dd25c762-06bd-4e44-80de-17af7087a907"), "The duration is 1 hour.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("cbdea7ef-3204-4e61-a716-0f75432e126a"),
                Name = "Darkvision Elixir (Greater)",
                Usage = "Held in 1 hand",
                Level = 8,
				Price = 9000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d3ada94f-c3b5-443b-ab50-cf3830079163"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("36ec2ffa-e72b-45b5-857b-23d89118779a"), "The duration is 24 hours.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f33d928b-f611-4f3b-909e-6889f5cffa29"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("bf99b38a-6ce3-471f-b989-1f1ca15421bd"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("10add9ee-6cc5-44a2-a094-bb1d632b39ba"), Traits.Instances.Consumable.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d6014ec-8673-4ab8-b0ed-4ab1690a713c"),
                SourceId = CoreRulebook.ID,
                Page = 547
            };
        }
    }
}
