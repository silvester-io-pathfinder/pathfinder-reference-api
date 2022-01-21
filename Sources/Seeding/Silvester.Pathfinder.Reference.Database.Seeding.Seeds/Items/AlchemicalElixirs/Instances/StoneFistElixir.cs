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
    public class StoneFistElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("58f3f7fd-4244-4a42-b684-d995220d4ade");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Stone Fist Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("cdcd2d5b-5901-4d52-81b9-7645684928c0"), "Your fists become hard as stone. For 1 hour, your fists deal 1d6 bludgeoning damage and lose the nonlethal trait."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("e393357d-29cf-42ba-bbab-01f227faebfb"),
                Name = "Stone Fist Elixir",
                Usage = "Held in 1 hand",
                Level = 4,
				Price = 1300,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Standard.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e3de146d-d598-4e3b-aeb5-76524f8fe177"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("59dc8bee-1b83-43f4-967f-91f998858890"), "The Stone Fist Elixir only exists as a single unclassified potency.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("fdaf606a-f157-4b1a-ad9d-120490e3d232"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("477d0112-e5e2-447a-8780-4f49438f8987"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("04e12944-96ed-459a-ba44-ef2ce41666d3"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("7258fd8a-bdd6-4238-8565-c9d255655fe9"), Traits.Instances.Morph.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87156a04-1bcc-4ec5-a7b6-ad44e0189935"),
                SourceId = CoreRulebook.ID,
                Page = 550
            };
        }
    }
}
