
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalBombs.Instances
{
    public class Thunderstone : Template
    {
        public static readonly Guid ID = Guid.Parse("cdfc6ce6-04ca-4220-a5c6-73eee8d2f0d5");

        protected override AlchemicalBomb GetAlchemicalBomb()
        {
            return new AlchemicalBomb
            {
                Id = ID,
                Name = "Thunderstone",
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("20d5ff89-8610-4d24-aa16-0ca19fef7847"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("578bfc39-f4cf-4909-a9ae-4b917f37327d"), Traits.Instances.Bomb.ID);
            builder.Add(Guid.Parse("a92c6819-e2c1-419d-9e3f-114e2a785def"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e5765069-bb6e-43be-b5ea-fcafc2e17ce3"), Traits.Instances.Sonic.ID);
            builder.Add(Guid.Parse("1d5566c7-4f02-4217-b799-3dc1da1fa146"), Traits.Instances.Splash.ID);
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("670226b5-e794-4898-b2be-94c63cf5408e"), "When this stone hits a creature or a hard surface, it explodes with a deafening bang. A thunderstone deals the listed sonic damage and sonic splash damage, and each creature within 10 feet of the space in which the stone exploded must succeed at a Fortitude saving throw with the listed DC or be deafened until the end of its next turn. Many types of thunderstone grant an item bonus to attack rolls.");;
        }

        protected override IEnumerable<AlchemicalBombVariant> GetAlchemicalBombVariants()
        {
            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("2442bad4-86cc-4145-bee7-d696a7ccb2cc"),
                Name = "Thunderstone (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("4cd5a0af-8184-480b-a3ce-49e6c0d5ec7d"), "The bomb deals 1d4 sonic damage and 1 sonic splash damage, and the DC is 17.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("045a850e-bf35-4bd6-bed2-37acce2c9674"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("592cf1a3-5509-4b31-b436-c5ccd88e9b59"),
                Name = "Thunderstone (Moderate)",
                Usage = "Held in 1 hand",
                Level = 3,
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("943dbd82-3b26-4d02-b7a9-ae114f5a536f"), "You gain a +1 item bonus to attack rolls. The bomb deals 2d4 sonic damage and 2 sonic splash damage, and the DC is 20.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("ab85bc49-71c4-4045-ba91-801bd5662889"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };
          
            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("8a0c09f3-8d30-4bb6-b6e3-19b9f7b87f13"),
                Name = "Thunderstone (Greater)",
                Usage = "Held in 1 hand",
                Level = 11,
                Price = 25000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("ca009af6-9aa8-49f7-8fd5-267b07756e7c"), "You gain a +2 item bonus to attack rolls. The bomb deals 3d4 sonic damage and 3 sonic splash damage, and the DC is 28.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("a77ceab1-e31e-447c-9397-431ca2528bb9"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };
         
            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("e2361f6e-5c3d-4caa-a11d-e55d5dda3f2a"),
                Name = "Thunderstone (Major)",
                Usage = "Held in 1 hand",
                Level = 17,
                Price = 250000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("cc3ca879-065b-455f-962d-50b31164babe"), "You gain a +3 item bonus to attack rolls. The bomb deals 4d4 sonic damage and 4 sonic splash damage, and the DC is 36.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("589f9ec7-5572-4d16-a5fa-07f569e498ba"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
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
                Id = Guid.Parse("797f5f94-6919-4064-9fde-9823f4bc73b9"),
                SourceId = CoreRulebook.ID,
                Page = 546
            };
        }
    }
}
