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
    public class FrostVial : Template
    {
        public static readonly Guid ID = Guid.Parse("f121fc6c-44bd-4528-9673-709f81627688");

        protected override AlchemicalBomb GetAlchemicalBomb()
        {
            return new AlchemicalBomb
            {
                Id = ID,
                Name = "Frost Vial",
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("65944497-d1f0-448c-b9b1-f44842f13640"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("598bd2fa-3d5e-4eaf-8f21-d1b9505aebca"), Traits.Instances.Bomb.ID);
            builder.Add(Guid.Parse("aa84ee92-2294-4689-80da-6e60ed7aeae8"), Traits.Instances.Cold.ID);
            builder.Add(Guid.Parse("fff163bf-552e-4ae9-9a6d-52bf45e0ae5e"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("6147639b-0802-4c95-9210-88430e7ba629"), Traits.Instances.Splash.ID);
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3a949c9e-d4c8-4496-bb1a-71fea4bef008"), "The liquid reagents in this vial rapidly absorb heat when exposed to air. A frost vial deals the listed cold damage and cold splash damage. On a hit, the target takes a status penalty to its Speeds until the end of its next turn. Many types of frost vial also grant an item bonus to attack rolls.");;
        }

        protected override IEnumerable<AlchemicalBombVariant> GetAlchemicalBombVariants()
        {
            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("9d329a79-8888-4d7a-b0b5-07cc3a58ccaf"),
                Name = "Frost Vial (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("1e85eb6c-973f-4382-8d01-0d28b8545578"), "The bomb deals 1d6 cold damage and 1 cold splash damage, and the target takes a –5-foot penalty.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("3abcd7f9-3ce6-4bf7-b572-590050d68b94"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("f77093af-ad47-474a-b8cd-b1913ec62145"),
                Name = "Frost Vial (Moderate)",
                Usage = "Held in 1 hand",
                Level = 3,
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("24f3db8c-3dc6-4fc5-beb7-78ee7dec499d"), "You gain a +1 item bonus to attack rolls, the bomb deals 2d6 cold damage and 2 cold splash damage, and the target takes a –10-foot penalty.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("9f7c3e59-dbe3-4d3e-b27a-7aed2be15f22"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("ec955cf0-b5c3-43f1-90ee-c3aaeae9d329"),
                Name = "Frost Vial (Greater)",
                Usage = "Held in 1 hand",
                Level = 11,
                Price = 25000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("1514f928-e3fb-40b7-ac27-754b8dad7b7f"), "You gain a +2 item bonus to attack rolls, the bomb deals 3d6 cold damage and 3 cold splash damage, and the target takes a –10-foot penalty.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("21a4b2ed-4abc-47bd-9abc-c8d86972c5b8"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("d0289952-2f3e-4bfd-baa0-3209e37da2b6"),
                Name = "Frost Vial (Major)",
                Usage = "Held in 1 hand",
                Level = 17,
                Price = 250000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("f1f9e95a-6485-4d2c-8e3a-4ab59f2f9618"), "You gain a +3 item bonus to attack rolls, the bomb deals 4d6 cold damage and 4 cold splash damage, and the target takes a –15-foot penalty.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("25fa8f68-f2fc-423e-b268-470ef964164d"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
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
                Id = Guid.Parse("af1a9b81-dd1c-4fb3-8266-c9f932ce4e88"),
                SourceId = CoreRulebook.ID,
                Page = 545
            };
        }
    }
}
