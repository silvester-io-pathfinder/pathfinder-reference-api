using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalBombs.Instances
{
    public class AcidFlask : Template
    {
        public static readonly Guid ID = Guid.Parse("05e7fbc0-da5c-4194-bd5a-daa6b05ba421");

        protected override AlchemicalBomb GetAlchemicalBomb()
        {
            return new AlchemicalBomb
            {
                Id = ID,
                Name = "Acid Flask",
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("84742016-7da9-4faf-b58a-86c615b14a9a"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("39f9ef5a-2e00-43e7-af3c-e1b5bb119d80"), Traits.Instances.Bomb.ID);
            builder.Add(Guid.Parse("2cefce32-f276-4853-8ef9-b7ff85e994f9"), Traits.Instances.Acid.ID);
            builder.Add(Guid.Parse("016b1504-c066-43df-a1aa-11a5aa4d6389"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("27107350-fdae-4ac3-8658-6c3ad9b3fa62"), Traits.Instances.Splash.ID);
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("575fcbde-26ab-4b04-8856-d3ff1612f7f3"), "This flask filled with corrosive acid deals 1 acid damage, the listed persistent acid damage, and the listed acid splash damage. Many types grant an item bonus to attack rolls.");;
        }

        protected override IEnumerable<AlchemicalBombVariant> GetAlchemicalBombVariants()
        {
            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("5929e181-19f4-45bf-9d37-8ac1d3018211"),
                Name = "Acid Flask (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("7d242cda-85cf-4730-9349-a192da9b99b9"), "It deals 1d6 persistent acid damage and 1 acid splash damage.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("c5931618-6959-493f-942f-6466558e4530"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("a96f62ca-457c-4e96-8271-a134db850874"),
                Name = "Acid Flask (Moderate)",
                Usage = "Held in 1 hand",
                Level = 3,
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("f8822117-d7e3-4fc4-aee7-e6d21dd3062b"), "You gain a +1 item bonus to attack rolls. The bomb deals 2d6 persistent acid damage and 2 acid splash damage.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("470a6106-43ad-4920-93da-1ce936864f16"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("080939ae-8ab4-4b7a-986e-861ba3828efc"),
                Name = "Acid Flask (Greater)",
                Usage = "Held in 1 hand",
                Level = 11,
                Price = 25000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("27b76261-6dc2-457a-8340-4689f327ffa2"), "You gain a +2 item bonus to attack rolls. The bomb deals 3d6 persistent acid damage and 3 acid splash damage.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("c6f5e8ac-fe12-410e-aa80-b082645e7ef5"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("ec84fb6f-a71f-44a8-8064-7d41cfd4d565"),
                Name = "Acid Flask (Major)",
                Usage = "Held in 1 hand",
                Level = 17,
                Price = 250000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("ff308301-44e8-4a8b-8108-1ee4774dbde4"), "You gain a +3 item bonus to attack rolls. The bomb deals 4d6 persistent acid damage and 4 acid splash damage.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("b1901255-2550-45b4-bbf5-d0f53dce3fa9"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05e99663-a3fb-498d-8cdb-702190ac8f65"),
                SourceId = CoreRulebook.ID,
                Page = 544
            };
        }
    }
}
