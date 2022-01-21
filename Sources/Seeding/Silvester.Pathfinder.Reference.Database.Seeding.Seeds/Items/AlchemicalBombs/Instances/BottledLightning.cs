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
    public class BottledLightning : Template
    {
        public static readonly Guid ID = Guid.Parse("2a6ab15a-5dd7-4c2c-b551-500821023ac7");

        protected override AlchemicalBomb GetAlchemicalBomb()
        {
            return new AlchemicalBomb
            {
                Id = ID,
                Name = "Bottled Lightning",
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f0af0d61-7f6d-4159-b801-4f6f3d89f433"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("e17242f6-989f-45f2-bc87-e599bf29bb5a"), Traits.Instances.Bomb.ID);
            builder.Add(Guid.Parse("ad204737-694f-4db2-b4c3-e005c24f1468"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("29cf04c6-4569-40fc-b6ad-b28538d7c5af"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("55b909a4-b168-42d4-bc37-2ef5a182f4b9"), Traits.Instances.Splash.ID);
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d487c00d-1ea3-4f9a-83cd-eba70c9614fd"), "Bottled lightning is packed with volatile reagents that create a blast of electricity when they are exposed to air. Bottled lightning deals the listed electricity damage and electricity splash damage. On a hit, the target becomes flat-footed until the start of your next turn. Many types grant an item bonus to attack rolls.");;
        }

        protected override IEnumerable<AlchemicalBombVariant> GetAlchemicalBombVariants()
        {
            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("0733aabb-aa51-4405-a5fa-d8368288f106"),
                Name = "Bottled Lightning (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("d3bc194e-808e-4a08-b8dd-f9ba01f84317"), "It deals 1d6 electricity damage and 1 electricity splash damage.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("f0417843-9248-4f2b-b58e-ebedee3e174a"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("26abf99d-95ab-46a8-af26-3fac3af578be"),
                Name = "Bottled Lightning (Moderate)",
                Usage = "Held in 1 hand",
                Level = 3,
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("5ef3db34-9a37-4f0e-beaf-63fc65a49e07"), "You gain a +1 item bonus to attack rolls. The bomb deals 2d6 electricity damage and 2 electricity splash damage.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("6913f658-0a0d-4b53-b4cc-125c69089e09"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("449e0cb8-5e05-42ea-b12a-73d059829315"),
                Name = "Bottled Lightning (Greater)",
                Usage = "Held in 1 hand",
                Level = 11,
                Price = 25000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("55d2c3fc-3772-4657-bc12-f0901f8ef4be"), "You gain a +2 item bonus to attack rolls. The bomb deals 3d6 electricity damage and 3 electricity splash damage.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("a90b972d-489f-4909-97fa-cb3a9c2fca68"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("41e63f50-d1c8-400a-a74b-8299172bdf08"),
                Name = "Bottled Lightning (Major)",
                Usage = "Held in 1 hand",
                Level = 17,
                Price = 250000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("05923526-befc-41ee-bc02-36af759ce89c"), "You gain a +3 item bonus to attack rolls. The bomb deals 4d6 electricity damage and 4 electricity splash damage.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("eec70f19-ebde-4027-952c-1378e8e2bfff"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
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
                Id = Guid.Parse("e69c3d9f-ec8d-43d5-89b4-68c8aae4eafa"),
                SourceId = CoreRulebook.ID,
                Page = 544
            };
        }
    }
}
