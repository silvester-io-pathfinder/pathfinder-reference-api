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
    public class AlchemistsFire : Template
    {
        public static readonly Guid ID = Guid.Parse("3e95680d-1c87-457c-91b0-e6e5cf29bee8");

        protected override AlchemicalBomb GetAlchemicalBomb()
        {
            return new AlchemicalBomb
            {
                Id = ID,
                Name = "Alchemist's Fire",
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("00764676-16ac-4f2e-bcb2-ffdfe4d584f8"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("5699ab25-2ca3-4732-8630-ffae7a46e03e"), Traits.Instances.Bomb.ID);
            builder.Add(Guid.Parse("ce66405f-088e-40ea-a5e7-85c66863169b"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("f6e500ad-3ec0-48fd-8b7e-1bcfa3bc5456"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("24e996db-2fbb-445d-86e9-6133bdc5087c"), Traits.Instances.Splash.ID);
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7ea74824-5235-4b72-bc3e-813400c45c57"), "Alchemist's fire is a combination of volatile liquids that ignite when exposed to air. Alchemist's fire deals the listed fire damage, persistent fire damage, and splash damage. Many types grant an item bonus to attack rolls.");;
        }

        protected override IEnumerable<AlchemicalBombVariant> GetAlchemicalBombVariants()
        {
            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("a430f92d-8144-4dfb-80c9-7bfa3da00c9e"),
                Name = "Alchemist's Fire (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID, 
                PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("dd71fbc6-a588-47c8-ad0a-cf8f12a70d09"), "The bomb deals 1d8 fire damage, 1 persistent fire damage, and 1 fire splash damage.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("4187c6cf-83f0-442a-8dc0-0636bf2dc77d"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("bac95f2d-c862-47b0-a9c0-f8cbfa3c76c3"),
                Name = "Alchemist's Fire (Moderate)",
                Usage = "Held in 1 hand",
                Level = 3,
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,   
                PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("9c6c388a-3cb9-47d5-b9ad-cfed03d5b3ac"), "You gain a +1 item bonus to attack rolls. The bomb deals 2d8 fire damage, 2 persistent fire damage, and 2 fire splash damage.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("45d655ee-e482-459b-891c-31e9cc2a6200"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("9a02b6aa-995e-4058-8609-b480970e8a7a"),
                Name = "Alchemist's Fire (Greater)",
                Usage = "Held in 1 hand",
                Level = 11,
                Price = 25000,
                BulkId = Bulks.Instances.LightBulk.ID   ,             
                PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("b976064f-b93f-4940-9a83-2feb860870d6"), "You gain a +2 item bonus to attack rolls. The bomb deals 3d8 fire damage, 3 persistent fire damage, and 3 fire splash damage.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("afc3aeb3-e7e7-4a03-997c-5578856db855"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("80b7856f-fd70-49bd-8616-f5e6d6d01cce"),
                Name = "Alchemist's Fire (Major)",
                Usage = "Held in 1 hand",
                Level = 17,
                Price = 250000,
                BulkId = Bulks.Instances.LightBulk.ID,                
                PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("a93d811b-5114-4995-b2a9-a64545eb2061"), "You gain a +3 item bonus to attack rolls. The bomb deals 4d8 fire damage, 4 persistent fire damage, and 4 fire splash damage.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("f3cdd510-96f4-4c43-8951-15aa0225244a"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
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
                Id = Guid.Parse("7ea74824-5235-4b72-bc3e-813400c45c57"),
                SourceId = CoreRulebook.ID,
                Page = 545
            };
        }
    }
}
